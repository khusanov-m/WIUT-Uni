<template>
  <div class="home">
    <h1>{{ getHeading(courses.length) }}</h1>
    <section class="container courses-container" v-if="courses.length">
      <div class="courses__card" v-for="course in courses" :key="course._id">
        <div class="courses__card-img">
          <img :src="course.coverImg" alt="course cover page" />
        </div>
        <h3 class="courses__card-title">{{ course.title }}</h3>
        <div class="courses__card-info">
          <div class="courses__card-details">
            <p class="courses__card-author">Author: {{ course.author }}</p>
            <p class="courses__card-price">Price: ${{ course.price }}</p>
            <p class="courses__card-duration">
              Duration: {{ course.duration }} hours
            </p>
            <p class="courses__card-description">
              Description: {{ course.description }}
            </p>
          </div>
          <div class="courses__card-btns">
            <button @click="toggleFavorite(course._id)">
              <i
                v-if="course.isFavorite"
                class="courses__card-isFavorite fa-solid fa-heart"
              ></i>
              <i
                v-else
                class="courses__card-isFavorite fa-regular fa-heart"
              ></i>
            </button>
            <button class="icon icon__edit" @click="editCourse(course._id)">
              <i class="fa-solid fa-pen-to-square"></i>
            </button>
            <button class="icon icon__delete" @click="deleteCourse(course._id)">
              <i class="fa-solid fa-trash"></i>
            </button>
          </div>
        </div>
      </div>
    </section>
    <section v-else>
      <div class="courses__card courses__card-no">
        <h3 class="courses__card-title"></h3>
        <router-link to="/create"
          >Let's add the new one <i class="fa-solid fa-arrow-right-long"></i
        ></router-link>
      </div>
    </section>
  </div>
</template>

<script>
export default {
  name: "Home",
  data() {
    return {
      courses: [],
      nodata: false,
    };
  },
  methods: {
    getHeading(length) {
      return length ? "All Courses" : "No courses in the records";
    },
    async getAllCourses() {
      const result = await this.axios.get("/courses");
      const { data } = result;
      this.courses = data.courses;
    },
    async deleteCourse(id) {
      await this.axios.delete(`/courses/${id}`);
      this.getAllCourses();
      this.$router.push("/");
    },
    async editCourse(id) {
      this.$router.push(`/edit/${id}`);
    },
    async toggleFavorite(id) {
      const result = await this.axios.get(`/courses/${id}`);
      const {
        data: { data },
      } = result;
      const isFav = data.courses.isFavorite;
      await this.axios.put(`/courses/${id}`, {
        isFavorite: !isFav,
      });
      this.getAllCourses();
    },
  },
  mounted() {
    this.getAllCourses();
  },
};
</script>

<style lang="scss" scoped>
@import "@/styles/variables.scss";

.courses__card {
  a {
    display: flex;
    justify-content: center;
    align-items: center;
    background: $font-color-01;
    padding: 1rem 2rem;
    border-radius: 1.5rem;
    margin: 0 auto;

    i {
      margin-left: 1.5rem;
    }
  }

  &-no {
    min-height: 65.9vh;
    display: flex;
    flex-direction: column;
  }
}
</style>

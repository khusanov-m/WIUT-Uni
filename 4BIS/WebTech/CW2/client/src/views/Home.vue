<template>
  <div class="home">
    <section class="courses-container" v-if="courses.length">
      <div class="courses__card" v-for="course in courses">
        <div class="courses__card-img">
          <img :src="course.coverImg" alt="course cover page" />
        </div>
        <div class="courses__card-info">
          <h3 class="courses__card-title">Title: {{ course.title }}</h3>
          <p class="courses__card-author">Author: {{ course.author }}</p>
          <p class="courses__card-price">Price: {{ course.price }}</p>
          <p class="courses__card-duration">Duration: {{ course.duration }}</p>
          <p class="courses__card-description">
            Description: {{ course.description }}
          </p>
          <button @click="toggleFavorite(course._id)">
            <i
              v-if="course.isFavorite"
              class="courses__card-isFavorite fa-solid fa-heart"
            ></i>
            <i v-else class="courses__card-isFavorite fa-regular fa-heart"></i>
          </button>
          <button class="icon icon__edit" @click="editCourse(course._id)">
            <i class="fa-solid fa-pen-to-square"></i>
          </button>
          <button class="icon icon__delete" @click="deleteCourse(course._id)">
            <i class="fa-solid fa-trash"></i>
          </button>
        </div>
      </div>
    </section>
    <section v-else>
      <div class="courses__card">
        <h3 class="courses__card-title">No courses in the records</h3>
        <router-link to="/create">Let's add the new one</router-link>
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

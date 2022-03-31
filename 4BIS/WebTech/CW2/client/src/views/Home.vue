<template>
  <div class="home">
    <section class="courses-container">
      <div class="courses__card" v-for="course in courses">
        <div class="courses__card-img">
          <img :src="course.coverImg" alt="course cover page" />
        </div>
        <div class="courses__card-info">
          <h3 class="courses__card-title">{{ course.title }}</h3>
          <p class="courses__card-author">{{ course.author }}</p>
          <p class="courses__card-price">{{ course.price }}</p>
          <p class="courses__card-duration">{{ course.duration }}</p>
          <p class="courses__card-description">{{ course.description }}</p>
          <p class="courses__card-isFavorite">{{ course.isFavorite }}</p>

          <button @click="editCourse(course._id)">Edit</button>
          <button @click="deleteCourse(course._id)">Delete</button>
          <span class="mdi mdi-home"></span>
        </div>
      </div>
    </section>
  </div>
</template>

<script>
import { defineComponent } from "vue";

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
      console.log(this.courses);
    },
    async deleteCourse(id) {
      await this.axios.delete(`/courses/${id}`);
      this.getAllCourses();
      this.$router.push("/");
    },
    async editCourse(id) {
      this.$router.push(`/edit/${id}`);
    },
  },
  mounted() {
    this.getAllCourses();
  },
};
</script>

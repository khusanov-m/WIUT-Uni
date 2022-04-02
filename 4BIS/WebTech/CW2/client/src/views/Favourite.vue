<template>
  <div class="courses">
    <h1>{{ getHeading(favs.length) }}</h1>
    <section class="container courses-container" v-if="favs.length">
      <div class="courses__card" v-for="fav in favs" :key="fav._id">
        <div class="courses__card-img">
          <img :src="fav.coverImg" alt="fav cover page" />
        </div>
        <h3 class="courses__card-title">{{ fav.title }}</h3>
        <div class="courses__card-info">
          <div class="courses__card-details">
            <p class="courses__card-author">Author: {{ fav.author }}</p>
            <p class="courses__card-price">Price: {{ fav.price }}</p>
            <p class="courses__card-duration">Duration: {{ fav.duration }}</p>
            <p class="courses__card-description">
              Description: {{ fav.description }}
            </p>
          </div>
          <div class="courses__card-btns">
            <button @click="toggleFavorite(fav._id)">
              <i class="courses__card-isFavorite fa-solid fa-heart"></i>
            </button>
            <button class="icon icon__edit" @click="editCourse(fav._id)">
              <i class="fa-solid fa-pen-to-square"></i>
            </button>
            <button class="icon icon__delete" @click="deleteCourse(fav._id)">
              <i class="fa-solid fa-trash"></i>
            </button>
          </div>
        </div>
      </div>
    </section>
    <section v-else>
      <div class="courses__card courses__card-no">
        <h3 class="courses__card-title"></h3>
        <router-link to="/"
          >Let's add to Favs some Courses <i class="fa-solid fa-arrow-right-long"></i
        ></router-link>
      </div>
    </section>
  </div>
</template>
<script>
export default {
  data() {
    return {
      favs: [],
    };
  },
  methods: {
    getHeading(length) {
      return length
        ? `Favourites`
        : "You don't have any favourite courses";
    },
    async getFavsCourse() {
      const result = await this.axios.get("/courses/favs");
      const {
        data: { data },
      } = result;
      this.favs = data;
    },
    async deleteCourse(id) {
      await this.axios.delete(`/courses/${id}`);
      this.getFavsCourse();
    },
    async editCourse(id) {
      this.$router.push(`/edit/${id}`);
    },
    async toggleFavorite(id) {
      await this.axios.put(`/courses/${id}`, { isFavorite: false });
      this.getFavsCourse();
    },
  },
  mounted() {
    this.getFavsCourse();
  },
};
</script>
<style lang="scss" scoped></style>

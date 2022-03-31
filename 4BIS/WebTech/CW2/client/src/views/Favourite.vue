<template>
  <div class="favs">
    <p>FAVOURITES</p>
    <section class="favs-container">
      <div class="favs__card" v-for="fav in favs">
        <div class="favs__card-img">
          <img :src="fav.coverImg" alt="fav cover page" />
        </div>
        <div class="favs__card-info">
          <h3 class="favs__card-title">Title: {{ fav.title }}</h3>
          <p class="favs__card-author">Author: {{ fav.author }}</p>
          <p class="favs__card-price">Price: {{ fav.price }}</p>
          <p class="favs__card-duration">Duration: {{ fav.duration }}</p>
          <p class="favs__card-description">
            Description: {{ fav.description }}
          </p>
          <button @click="toggleFavorite(fav._id)">
            <i class="favs__card-isFavorite fa-solid fa-heart"></i>
          </button>
          <button class="icon icon__edit" @click="editCourse(fav._id)">
            <i class="fa-solid fa-pen-to-square"></i>
          </button>
          <button class="icon icon__delete" @click="deleteCourse(fav._id)">
            <i class="fa-solid fa-trash"></i>
          </button>
        </div>
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
<style lang=""></style>

<template>
  <div class="favs">
    <p>FAVOURITES</p>
    <section class="favs-container">
      <div class="favs__card" v-for="fav in favs">
        <div class="favs__card-img">
          <img :src="fav.coverImg" alt="fav cover page" />
        </div>
        <div class="favs__card-info">
          <h3 class="favs__card-title">{{ fav.title }}</h3>
          <p class="favs__card-author">{{ fav.author }}</p>
          <p class="favs__card-price">{{ fav.price }}</p>
          <p class="favs__card-duration">{{ fav.duration }}</p>
          <p class="favs__card-description">{{ fav.description }}</p>
          <p class="favs__card-isFavorite">{{ fav.isFavorite }}</p>

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
      const { data: { data } } = result;
      this.favs = data;
      console.log(this.favs);
    },
  },
  mounted() {
    this.getFavsCourse();
  },
};
</script>
<style lang=""></style>

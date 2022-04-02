<template>
  <nav class="nav">
    <router-link to="/">Home</router-link> |
    <router-link to="/create">Create a Course</router-link> |
    <router-link to="/favourite">Favourites</router-link>
  </nav>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
.nav {
  display: flex;
  justify-content: space-evenly;
  align-items: center;
  padding: 1rem;
  margin: 0 auto 3rem;
}
</style>

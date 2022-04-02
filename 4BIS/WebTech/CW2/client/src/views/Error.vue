<template>
  <div class="error">
    <h1>Not Found Page</h1>
    <p>The page you are looking for does not exist.</p>
    <router-link to="/">Return to Homepage</router-link>
    <img src="../assets/404.svg" alt="">
  </div>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
.error {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: space-between;
  text-align: center;

  img {
    border: none;
    object-fit: contain;
    background: transparent;
    border-radius: 0;
  }
}
</style>

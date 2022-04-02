<template>
  <div class="error">
    <div class="">
      <h1>Not Found Page</h1>
      <p>The page you are looking for does not exist.</p>
      <router-link to="/"
        ><i class="fa-solid fa-arrow-left"></i> Return to Homepage</router-link
      >
    </div>
    <img src="../assets/404.svg" alt="" />
  </div>
</template>
<script>
export default {};
</script>
<style lang="scss" scoped>
@import "@/styles/variables.scss";

.error {
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: center;
  min-height: 79.98vh;

  img {
    border: none;
    object-fit: contain;
    background: transparent;
    border-radius: 0;
  }

  p {
    margin-bottom: 2.5rem;
  }

  i {
    margin-right: 1rem;
  }

  a {
    padding: 1.5rem 2rem;
    color: $font-color-08;
    background: $bg-tertiary;
    border-radius: 3rem;
  }
}
</style>

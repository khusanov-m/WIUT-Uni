<template lang="">
  <div>
    <p>CREATE</p>
    <form>
      <!-- <div class="form__input" v-for="field in fields">
        <label :for="purpose" v-if="tip">{{ tip }}</label>
        <input
          :type="text"
          :placeholder="example"
          :id="purpose"
          :value="init"
          :checked="boolean"
          :v-model="bind"
        />
      </div> -->

      <img :src="previewUrl" alt="Preview Place Holder" />
      <button @click.prevent="displayPreview()">
        Preview Image <i class="fa-solid fa-arrow-rotate-right"></i>
      </button>

      <div class="form__input">
        <label :for="fields[0].purpose" v-if="fields[0].tip">{{
          fields[0].tip
        }}</label>
        <input
          :type="fields[0].text"
          :placeholder="fields[0].example"
          :id="fields[0].purpose"
          v-model="title"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[1].purpose" v-if="fields[1].tip">{{
          fields[1].tip
        }}</label>
        <input
          :type="fields[1].text"
          :placeholder="fields[1].example"
          :id="fields[1].purpose"
          v-model="description"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[2].purpose" v-if="fields[2].tip">{{
          fields[2].tip
        }}</label>
        <input
          :type="fields[2].text"
          :placeholder="fields[2].example"
          :id="fields[2].purpose"
          v-model="coverImg"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[3].purpose" v-if="fields[3].tip">{{
          fields[3].tip
        }}</label>
        <input
          :type="fields[3].text"
          :placeholder="fields[3].example"
          :id="fields[3].purpose"
          v-model="author"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[4].purpose" v-if="fields[4].tip">{{
          fields[4].tip
        }}</label>
        <input
          :type="fields[4].text"
          :placeholder="fields[4].example"
          :id="fields[4].purpose"
          v-model="price"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[5].purpose" v-if="fields[5].tip">{{
          fields[5].tip
        }}</label>
        <input
          :type="fields[5].text"
          :placeholder="fields[5].example"
          :id="fields[5].purpose"
          v-model="duration"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[6].purpose" v-if="fields[6].tip">{{
          fields[6].tip
        }}</label>
        <input
          type="checkbox"
          :placeholder="fields[6].example"
          :id="fields[6].purpose"
          v-model="isFavorite"
          required
        />
      </div>

      <button @click.prevent="create">
        Create <i class="fa-solid fa-folder-plus"></i>
      </button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      author: "",
      coverImg: "",
      description: "",
      duration: "",
      price: "",
      title: "",
      isFavorite: false,
      previewUrl:
        "https://images.unsplash.com/photo-1518186233392-c232efbf2373?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80",
      fields: [
        {
          tip: "Title",
          purpose: "title",
          text: "text",
          example: "VueJS 3 Bootcamp 2022",
          bind: "title",
        },
        {
          tip: "Description",
          purpose: "description",
          text: "text",
          example:
            "In this course, you will learn how to build a VueJS 3 application",
          bind: "description",
        },
        {
          tip: "Cover Image",
          purpose: "coverImg",
          text: "text",
          example: "url.com/image.jpg",
          bind: "coverImg",
        },
        {
          tip: "Author",
          purpose: "author",
          text: "text",
          example: "Jonas Schmedtmann",
          bind: "author",
        },
        {
          tip: "Price ($)",
          purpose: "price",
          text: "number",
          example: "199",
          bind: "price",
        },
        {
          tip: "Duration (in hours)",
          purpose: "duration",
          text: "number",
          example: "12",
          bind: "duration",
        },
        {
          tip: "Is it your favourite?",
          purpose: "isFavourite",
          text: "checkbox",
          example: "",
          bind: "isFavorite",
        },
      ],
    };
  },
  methods: {
    displayPreview() {
      this.previewUrl = this.coverImg;
    },
    async create() {
      const form = {};
      form.author = this.author;
      form.coverImg = this.coverImg;
      form.description = this.description;
      form.duration = this.duration;
      form.price = this.price;
      form.title = this.title;
      form.isFavorite = this.isFavorite;

      console.log(form);

      if (
        form.author &&
        form.coverImg &&
        form.description &&
        form.duration &&
        form.price &&
        form.title
      ) {
        try {
          await this.axios.post(`/courses/`, form);
          this.$router.push("/");
        } catch (err) {
          console.log(err);
        }
      }
    },
  },
};
</script>

<style lang="scss">
.form__input {
  display: flex;
  align-items: center;
  border: 2px solid rgba(255, 255, 255, 0.3);

  &:not(:last-child) {
    margin-bottom: 20px;
  }

  label {
    margin-right: 0.5rem;
  }
}
</style>

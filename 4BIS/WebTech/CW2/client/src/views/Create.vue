<template>
  <div class="container">
    <h1>Add to your list new Course</h1>
    <form class="preview">
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
      <div class="form__preview">
        <img :src="previewUrl" alt="Preview Place Holder" />
        <button @click.prevent="displayPreview()">
          Preview Image <i class="fa-solid fa-arrow-rotate-right"></i>
        </button>
      </div>

      <h3>Please fill the form</h3>

      <div class="form__input">
        <label :for="fields[0].purpose" v-if="fields[0].tip"
          >{{ fields[0].tip }}:</label
        >
        <input
          :type="fields[0].text"
          :placeholder="fields[0].example"
          :id="fields[0].purpose"
          v-model="author"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[1].purpose" v-if="fields[1].tip"
          >{{ fields[1].tip }}:</label
        >
        <textarea
          :type="fields[1].text"
          :placeholder="fields[1].example"
          :id="fields[1].purpose"
          v-model="title"
          required
          contenteditable="true"
        ></textarea>
      </div>

      <div class="form__input">
        <label :for="fields[2].purpose" v-if="fields[2].tip"
          >{{ fields[2].tip }}:</label
        >
        <textarea
          :type="fields[2].text"
          :placeholder="fields[2].example"
          :id="fields[2].purpose"
          v-model="description"
          required
        ></textarea>
      </div>

      <div class="form__input">
        <label :for="fields[3].purpose" v-if="fields[3].tip"
          >{{ fields[3].tip }}:</label
        >
        <input
          :type="fields[3].text"
          :placeholder="fields[3].example"
          :id="fields[3].purpose"
          v-model="coverImg"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[4].purpose" v-if="fields[4].tip"
          >{{ fields[4].tip }}:</label
        >
        <input
          :type="fields[4].text"
          :placeholder="fields[4].example"
          :id="fields[4].purpose"
          v-model="price"
          required
        />
      </div>

      <div class="form__input">
        <label :for="fields[5].purpose" v-if="fields[5].tip"
          >{{ fields[5].tip }}:</label
        >
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
        <label class="switch">
          <input
            type="checkbox"
            :placeholder="fields[6].example"
            :id="fields[6].purpose"
            v-model="isFavorite"
            required
          />
          <span class="slider round"></span>
        </label>
      </div>

      <p v-if="errors.length" class="errorHandling">
        Please fill the following required fields:
        <span>{{ errorMessage }}</span>
      </p>

      <button class="form__btn" @click.prevent="create">
        Create <i class="fa-solid fa-folder-plus"></i>
      </button>
    </form>
  </div>
</template>

<script>
export default {
  data() {
    return {
      errors: [],
      errorMessage: "",
      author: "",
      coverImg: "",
      description: "",
      duration: "",
      price: "",
      title: "",
      isFavorite: false,
      previewUrl: "",
      fields: [
        {
          tip: "Author",
          purpose: "author",
          text: "text",
          example: "Jonas Schmedtmann",
          bind: "author",
        },
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
          tip: "Cover Image URL",
          purpose: "coverImg",
          text: "text",
          example: "url.com/image.jpg",
          bind: "coverImg",
        },

        {
          tip: "Price in USD",
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
      if (this.coverImg) {
        this.previewUrl = this.coverImg;
      }
    },
    displayErrors() {
      this.errorMessage = this.errors.map((error) => error).join(", ");
    },
    async create() {
      this.errors = [];
      const form = {};
      form.author = this.author;
      form.title = this.title;
      form.description = this.description;
      form.coverImg = this.coverImg;
      form.price = this.price;
      form.duration = this.duration;
      form.isFavorite = this.isFavorite;

      if (!this.author) this.errors.push("Author");
      if (!this.title) this.errors.push("Title");
      if (!this.description) this.errors.push("Description");
      if (!this.price) this.errors.push("Price");
      if (!this.duration) this.errors.push("Duration");

      if (this.errors.length) {
        this.displayErrors();
        return;
      }

      if (
        form.author &&
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
  mounted() {
    const images = [
      "https://images.unsplash.com/photo-1608501821300-4f99e58bba77?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
      "https://images.unsplash.com/photo-1527049979667-990f1d0d8e7f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
      "https://images.unsplash.com/photo-1517241034903-9a4c3ab12f00?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
      "https://images.unsplash.com/photo-1581284974086-f0a9d7bae871?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
      "https://images.unsplash.com/photo-1517999144091-3d9dca6d1e43?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=627&q=80",
      "https://images.unsplash.com/photo-1513569771920-c9e1d31714af?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
      "https://images.unsplash.com/photo-1475257026007-0753d5429e10?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
    ];
    this.previewUrl = images[Math.floor(Math.random() * images.length)];
  },
};
</script>

<style lang="scss" scoped>
@import "@/styles/variables.scss";

.container {
  flex-direction: column;

  h1,
  h3 {
    text-align: center;
  }

  h1 {
    margin-bottom: 3rem;
  }

  h3 {
    margin-bottom: 1.5rem;
  }
}
</style>

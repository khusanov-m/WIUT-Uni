<template lang="">
  <div class="container">
    <router-link to="/">
      <i class="fa-solid fa-chevron-left"></i>Go Back</router-link
    >
    <h1>Edit Course Page</h1>

    <form class="form">
      <div class="form__preview">
        <img :src="previewUrl" alt="Preview Place Holder" />
        <button @click.prevent="displayPreview()">
          Preview Image <i class="fa-solid fa-arrow-rotate-right"></i>
        </button>
      </div>

      <div class="form__input">
        <label for="author">{{ setLabel("author") }}</label>
        <input
          v-model="author"
          :type="checkType(courses.author)"
          :placeholder="giveExample(courses.author)"
          id="author"
        />
      </div>

      <div class="form__input">
        <label for="title">{{ setLabel("title") }}</label>
        <textarea
          v-model="title"
          :type="checkType(courses.title)"
          :placeholder="giveExample(courses.title)"
          id="title"
        ></textarea>
      </div>

      <div class="form__input">
        <label for="description">{{ setLabel("description") }}</label>
        <textarea
          v-model="description"
          :type="checkType(courses.description)"
          :placeholder="giveExample(courses.description)"
          id="description"
        ></textarea>
      </div>

      <div class="form__input">
        <label for="coverImg">{{ setLabel("coverImg") }}</label>
        <input
          v-model="coverImg"
          :type="checkType(courses.coverImg)"
          :placeholder="giveExample(courses.coverImg)"
          id="coverImg"
        />
      </div>

      <div class="form__input">
        <label for="price">{{ setLabel("price") }}</label>
        <input
          v-model="price"
          :type="checkType(courses.price)"
          :placeholder="giveExample(courses.price)"
          id="price"
        />
      </div>

      <div class="form__input">
        <label for="duration">{{ setLabel("duration") }}</label>
        <input
          v-model="duration"
          :type="checkType(courses.duration)"
          :placeholder="giveExample(courses.duration)"
          id="duration"
        />
      </div>

      <div class="form__input">
        <label for="isFavorite">{{ setLabel("isFavorite") }}</label>
        <label class="switch">
          <input v-model="isFavorite" type="checkbox" id="isFavorite" />
          <span class="slider round"></span>
        </label>
      </div>

      <p v-if="errors.length" class="errorHandling">
        Please fill the following required fields:
        <span>{{ errorMessage }}</span>
      </p>

      <button class="form__btn" @click.prevent="upload()">
        Update <i class="fa-solid fa-cloud-arrow-up"></i>
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
      courses: [],
      author: "",
      coverImg: "",
      description: "",
      duration: "",
      price: "",
      title: "",
      isFavorite: false,
      previewUrl: "",
    };
  },
  methods: {
    async getCourse() {
      try {
        const result = await this.axios.get(
          `/courses/${this.$route.params.id}`
        );
        const {
          data: { data },
        } = result;

        delete data.courses._id;
        delete data.courses.createdAt;
        delete data.courses.updatedAt;
        delete data.courses.__v;

        return data.courses;
      } catch (err) {
        console.log(err);
      }
    },
    checkType(value) {
      if (typeof value === "boolean") {
        return "checkbox";
      } else if (typeof value === "string") {
        return "text";
      } else {
        return typeof value;
      }
    },
    giveExample(key) {
      switch (key) {
        case key === "title":
          return "VueJS 3 Bootcamp 2022";
          break;
        case key === "description":
          return;
          "In this course, you will learn how to build a VueJS 3 application";
          break;
        case key === "coverImg":
          return "url.com/image.jpg";
          break;
        case key === "author":
          return "Jonas Schmedtmann";
          break;
        case key === "price":
          return "199";
          break;
        case key === "duration":
          return "2";
          break;
        default:
          break;
      }
    },
    setLabel(name) {
      let curr = name.charAt(0).toUpperCase() + name.slice(1);

      switch (curr) {
        case "Title":
          return "Title";
          break;
        case "Description":
          return "Description";
          break;
        case "CoverImg":
          return "Cover Image URL";
          break;
        case "Author":
          return "Author";
          break;
        case "Price":
          return "Price in USD";
          break;
        case "Duration":
          return "Duration (in hours)";
          break;
        case "IsFavorite":
          return "Is it your favourite?";
          break;
        default:
          break;
      }
    },
    checkChecked(value) {
      if (value === true) {
        return true;
      } else {
        return false;
      }
    },
    toggleFavorite() {
      this.isFavorite = !this.isFavorite;
    },
    displayErrors() {
      this.errorMessage = this.errors.map((error) => error).join(", ");
    },
    async upload() {
      this.errors = [];
      const form = {};
      form.author = this.author;
      form.coverImg = this.coverImg;
      form.description = this.description;
      form.duration = this.duration;
      form.price = this.price;
      form.title = this.title;
      form.isFavorite = this.isFavorite;

      form.coverImg = this.coverImg
        ? this.coverImg
        : "https://www.kindpng.com/picc/m/318-3180572_online-course-icon-hd-png-download.png";

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
          await this.axios.put(`/courses/${this.$route.params.id}`, form);
          this.$router.push("/");
        } catch (err) {
          console.log(err);
        }
      }
    },
    async setValues() {
      this.courses = await this.getCourse();
      this.previewUrl = this.courses.coverImg;
      this.author = this.courses.author;
      this.title = this.courses.title;
      this.description = this.courses.description;
      this.coverImg = this.courses.coverImg;
      this.price = this.courses.price;
      this.duration = this.courses.duration;
      this.isFavorite = this.courses.isFavorite;
    },
    displayPreview() {
      this.previewUrl = this.coverImg;
    },
  },

  mounted() {
    this.setValues();
  },
};
</script>

<style lang="scss" scoped>
.container {
  flex-direction: column;
}

h1 {
  margin-bottom: 3rem;
}
</style>

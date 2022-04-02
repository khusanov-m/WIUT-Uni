import mongoose from 'mongoose';

const courseSchema = new mongoose.Schema(
  {
    title: {
      type: String,
      required: [true, 'Course must have a title'],
      trim: true,
      unique: true,
    },
    description: {
      type: String,
      required: [true, 'Course must have a description'],
      trim: true,
    },
    coverImg: {
      type: String,
      required: false,
      trim: true,
      default:
        'https://www.kindpng.com/picc/m/318-3180572_online-course-icon-hd-png-download.png',
    },
    author: {
      type: String,
      required: [true, 'Course must have an author'],
      trim: true,
    },
    price: {
      type: Number,
      required: [true, 'Course must have a price'],
      trim: true,
    },
    duration: {
      type: Number,
      required: [true, 'Course must have a duration'],
      trim: true,
    },
    isFavorite: {
      type: Boolean,
      required: false,
      default: false,
    },
  },
  {
    timestamps: true,
  }
);

export const Course = mongoose.model('Course', courseSchema);

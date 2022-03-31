import mongoose from 'mongoose';
import env from 'dotenv';
import app from './';

env.config({ path: './.env' });

const DB: string = String(
  process.env.DB_URL?.replace('<PASSWORD>', String(process.env.DB_PASSWORD))
);

// MongoDB connection
(async () => {
  try {
    await mongoose.connect(DB);
    console.log('DB connected!');
  } catch (err) {
    console.log(err);
  }
})();

const { PORT } = process.env;

if (!PORT) {
  console.error('ERROR: No PORT specified');
  throw new Error('PORT is not defined in .env');
}

app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});

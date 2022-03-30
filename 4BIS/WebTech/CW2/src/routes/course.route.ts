import { Router } from 'express';
import * as courseController from '../controllers/course.controller';
const router: Router = Router();

router.route('/').get(courseController.getAllCourses);

router.route('/course/:id').get(courseController.getCourse)
router.route('/create').post(courseController.createCourse);
router.route('/update/:id').patch(courseController.updateCourse)
router.route('/delete/:id').delete(courseController.deleteCourse);

export default router;

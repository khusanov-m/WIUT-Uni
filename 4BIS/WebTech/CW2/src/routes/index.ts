import { Router } from 'express';

import courseRoutes from './course.route';

const router: Router = Router();

router.use('/courses', courseRoutes);

export default router;

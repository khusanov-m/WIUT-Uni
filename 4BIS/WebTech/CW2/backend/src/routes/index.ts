import { Router } from 'express';

import courseRoutes from './course.route';

const router: Router = Router();

router.use('/api/v1/courses', courseRoutes);

export default router;

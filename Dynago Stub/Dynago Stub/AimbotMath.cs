﻿namespace /*rnd*/DynagoStub/*rnd*/ {

    static class /*rnd*/cl_AimbotMath/*rnd*/  {

        /*order-start*/
        /*junk_method*/

        /*order-*/
        public struct /*rnd*/Vector3/*rnd*/  {
            /*order-start*/
            /*order-*/public float /*rnd*/x/*rnd*/;/*order-*/
            /*order-*/public float /*rnd*/y/*rnd*/;/*order-*/
            /*order-*/public float /*rnd*/z/*rnd*/;/*order-*/
            /*order-end*/

            public /*rnd*/Vector3/*rnd*/(float /*rnd*/_x/*rnd*/, float /*rnd*/_y/*rnd*/, float /*rnd*/_z/*rnd*/)
            {
                /*order-start*/
                /*order-*//*rnd*/x/*rnd*/ = /*rnd*/_x/*rnd*/;/*order-*/
                /*order-*//*rnd*/y/*rnd*/ = /*rnd*/_y/*rnd*/;/*order-*/
                /*order-*//*rnd*/z/*rnd*/ = /*rnd*/_z/*rnd*/;/*order-*/
                /*order-end*/
            }
        }
        /*order-*/

        /*junk_method*/

        /*order-*/
        public struct /*rnd*/Vector2/*rnd*/ {
            /*order-start*/
            /*order-*/public float /*rnd*/x/*rnd*/;/*order-*/
            /*order-*/public float /*rnd*/y/*rnd*/;/*order-*/
            /*order-end*/
        }
        /*order-*/

        /*junk_method*/

        /*order-*/
        public static /*rnd*/Vector3/*rnd*/ /*rnd*/met_GetBonePos/*rnd*/(int /*rnd*/var_TargetEntity/*rnd*/, int /*rnd*/var_BoneID/*rnd*/) {
            int /*rnd*/var_BoneMatrix/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(/*rnd*/var_TargetEntity/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/offset_BoneMatrix/*rnd*/);
            /*rnd*/Vector3/*rnd*/ /*rnd*/var_Vector/*rnd*/ = new /*rnd*/Vector3/*rnd*/();
            /*order-start*/
            /*order-*//*rnd*/var_Vector/*rnd*/./*rnd*/x/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_BoneMatrix/*rnd*/ + (0x30 */*rnd*/var_BoneID/*rnd*/) + 0xC);/*order-*/
            /*order-*//*rnd*/var_Vector/*rnd*/./*rnd*/y/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_BoneMatrix/*rnd*/ + (0x30 * /*rnd*/var_BoneID/*rnd*/) + 0x1C);/*order-*/
            /*order-*//*rnd*/var_Vector/*rnd*/./*rnd*/z/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(/*rnd*/var_BoneMatrix/*rnd*/ + (0x30 * /*rnd*/var_BoneID/*rnd*/) + 0x2C);/*order-*/
            /*order-end*/
            return /*rnd*/var_Vector/*rnd*/;
        }
        /*order-*/

        /*junk_method*/

        /*order-*/
        public static float /*rnd*/met_VectorDistance/*rnd*/(/*rnd*/Vector3/*rnd*/  /*rnd*/var_VectorA/*rnd*/, /*rnd*/Vector3/*rnd*/ /*rnd*/var_VectorB/*rnd*/) {
            /*rnd*/Vector3/*rnd*/  /*rnd*/var_VectorC/*rnd*/ = new /*rnd*/Vector3/*rnd*/ ();
            /*order-start*/
            /*order-*//*rnd*/var_VectorC/*rnd*/./*rnd*/x/*rnd*/ = /*rnd*/var_VectorA/*rnd*/./*rnd*/x/*rnd*/ - /*rnd*/var_VectorB/*rnd*/./*rnd*/x/*rnd*/;/*order-*/
            /*order-*//*rnd*/var_VectorC/*rnd*/./*rnd*/y/*rnd*/ = /*rnd*/var_VectorA/*rnd*/./*rnd*/y/*rnd*/ - /*rnd*/var_VectorB/*rnd*/./*rnd*/y/*rnd*/;/*order-*/
            /*order-*//*rnd*/var_VectorC/*rnd*/./*rnd*/z/*rnd*/ = /*rnd*/var_VectorA/*rnd*/./*rnd*/z/*rnd*/ - /*rnd*/var_VectorB/*rnd*/./*rnd*/z/*rnd*/;/*order-*/
            /*order-end*/
            return (float)System.Math.Sqrt((/*rnd*/var_VectorC/*rnd*/./*rnd*/x/*rnd*/ * /*rnd*/var_VectorC/*rnd*/./*rnd*/x/*rnd*/) + (/*rnd*/var_VectorC/*rnd*/./*rnd*/y/*rnd*/ * /*rnd*/var_VectorC/*rnd*/./*rnd*/y/*rnd*/) + (/*rnd*/var_VectorC/*rnd*/./*rnd*/z/*rnd*/ * /*rnd*/var_VectorC/*rnd*/./*rnd*/z/*rnd*/));
        }
        /*order-*/

        /*junk_method*/

        /*order-*/
        static double /*rnd*/met_Deg2Rad/*rnd*/(double /*rnd*/var_Degree/*rnd*/) {
            var /*rnd*/var_ToRadical/*rnd*/ = System.Math.PI / 180;
            return /*rnd*/var_Degree/*rnd*/ * /*rnd*/var_ToRadical/*rnd*/;
        }
        /*order-*/

        /*junk_method*/

        /*order-*/
        public static float /*rnd*/met_CalculateFOV/*rnd*/(/*rnd*/Vector3/*rnd*/ /*rnd*/var_ViewAngle/*rnd*/, /*rnd*/Vector3/*rnd*/  /*rnd*/dst/*rnd*/, float /*rnd*/var_Distance/*rnd*/) {
            /*order-start*/
            /*order-*/float /*rnd*/var_Pitch/*rnd*/ = (float)(System.Math.Sin(/*rnd*/met_Deg2Rad/*rnd*/(/*rnd*/var_ViewAngle/*rnd*/./*rnd*/x/*rnd*/ - /*rnd*/dst/*rnd*/./*rnd*/x/*rnd*/)) * /*rnd*/var_Distance/*rnd*/);/*order-*/
            /*order-*/float /*rnd*/var_Yaw/*rnd*/ = (float)(System.Math.Sin(/*rnd*/met_Deg2Rad/*rnd*/(/*rnd*/var_ViewAngle/*rnd*/./*rnd*/y/*rnd*/ - /*rnd*/dst/*rnd*/./*rnd*/y/*rnd*/)) * /*rnd*/var_Distance/*rnd*/);/*order-*/
            /*order-end*/
            return (float)System.Math.Sqrt(System.Math.Pow(/*rnd*/var_Pitch/*rnd*/, 2) + System.Math.Pow(/*rnd*/var_Yaw/*rnd*/, 2));
        }
        /*order-*/

        /*junk_method*/

        /*order-*/
        public static /*rnd*/Vector3/*rnd*/ /*rnd*/CalcAngle/*rnd*/(/*rnd*/Vector3/*rnd*/ /*rnd*/src/*rnd*/, /*rnd*/Vector3/*rnd*/ /*rnd*/dst/*rnd*/, bool /*rnd*/RSC/*rnd*/ = false) {
            /*order-start*/
            /*order-*//*rnd*/Vector3/*rnd*/ /*rnd*/angles/*rnd*/ = new /*rnd*/Vector3/*rnd*/ (/*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ = 0, /*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ = 0, /*rnd*/src/*rnd*/./*rnd*/z/*rnd*/ = 0);/*order-*/
            /*order-end*/

            /*order-start*/
            /*order-*/double[] /*rnd*/delta/*rnd*/ = { (/*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ - /*rnd*/dst/*rnd*/./*rnd*/x/*rnd*/), (/*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ - /*rnd*/dst/*rnd*/./*rnd*/y/*rnd*/), (/*rnd*/src/*rnd*/./*rnd*/z/*rnd*/ - /*rnd*/dst/*rnd*/./*rnd*/z/*rnd*/) };/*order-*/
            /*order-end*/

            /*order-start*/
            /*order-*/float /*rnd*/hyp/*rnd*/ = (float)System.Math.Sqrt(/*rnd*/delta/*rnd*/[0] * /*rnd*/delta/*rnd*/[0] + /*rnd*/delta/*rnd*/[1] * /*rnd*/delta/*rnd*/[1]);/*order-*/
            /*order-end*/

            /*order-start*/
            /*order-*//*rnd*/angles/*rnd*/./*rnd*/x/*rnd*/ = (float)(System.Math.Atan(/*rnd*/delta/*rnd*/[2] / /*rnd*/hyp/*rnd*/) * 180.0f / System.Math.PI);/*order-*/
            /*order-*//*rnd*/angles/*rnd*/./*rnd*/y/*rnd*/ = (float)(System.Math.Atan(/*rnd*/delta/*rnd*/[1] / /*rnd*/delta/*rnd*/[0]) * 180.0f / System.Math.PI);/*order-*/
            /*order-end*/

            if (/*rnd*/delta/*rnd*/[0] >= 0.0f) { /*rnd*/angles/*rnd*/./*rnd*/y/*rnd*/ += 180.0f; }

            if (/*rnd*/RSC/*rnd*/) {
                int /*rnd*/ShotsFired/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<int>(Program./*rnd*/LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/offset_ShotsFired/*rnd*/);
                if (/*rnd*/ShotsFired/*rnd*/ > 1) {
                    /*rnd*/Vector2/*rnd*/ /*rnd*/VectorPunch/*rnd*/ = new /*rnd*/Vector2/*rnd*/();
                    /*order-start*/
                    /*order-*//*rnd*/VectorPunch/*rnd*/./*rnd*/x/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(Program./*rnd*/LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/offset_AimPunch/*rnd*/);/*order-*/
                    /*order-*//*rnd*/VectorPunch/*rnd*/./*rnd*/y/*rnd*/ = /*rnd*/cl_Memory/*rnd*/./*rnd*/met_ReadMemory/*rnd*/<float>(Program./*rnd*/LocalPlayer/*rnd*/ + /*rnd*/cl_Offsets/*rnd*/./*rnd*/offset_AimPunch/*rnd*/ + 4);/*order-*/
                    /*order-end*/
                    /*order-start*/
                    /*order-*//*rnd*/angles/*rnd*/./*rnd*/x/*rnd*/ -= /*rnd*/VectorPunch/*rnd*/./*rnd*/x/*rnd*/ * 2.0f;/*order-*/
                    /*order-*//*rnd*/angles/*rnd*/./*rnd*/y/*rnd*/ -= /*rnd*/VectorPunch/*rnd*/./*rnd*/y/*rnd*/ * 2.0f;/*order-*/
                    /*order-end*/
                }
            }

            return /*rnd*/angles/*rnd*/;
        } 
        /*order-*/

        /*junk_method*/

        /*order-*/
        public static /*rnd*/Vector3/*rnd*/ /*rnd*/NormalizeAngle/*rnd*/(/*rnd*/Vector3/*rnd*/ /*rnd*/src/*rnd*/) {
            /*order-start*/
            /*order-*/
            while (/*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ > 89.0f) { /*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ -= 180.0f; }
            while (/*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ < -89.0f) { /*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ += 180.0f; }
            while (/*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ > 180.0f) { /*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ -= 360.0f; }
            while (/*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ < -180.0f) { /*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ += 360.0f; }
            if (/*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ < -180.0f || /*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ > 180.0f) { /*rnd*/src/*rnd*/./*rnd*/y/*rnd*/ = 0.0f; }
            if (/*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ < -89.0f || /*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ > 89.0f) { /*rnd*/src/*rnd*/./*rnd*/x/*rnd*/ = 0.0f; }
            /*order-*/
            /*order-end*/
            return /*rnd*/src/*rnd*/;
        }
        /*order-*/

        /*junk_method*/

        /*order-end*/
    }

}

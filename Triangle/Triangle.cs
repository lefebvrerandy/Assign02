/* 
 * Programmer:      Randy Lefebvre
 * Course Code:     INFO2180
 * Solution:        Assign02
 * Project:         Triangle
 * Description:     This project holds all methods for calculations.
 *                  In this class, there are three methods. First one 
 *                  takes two sides and returns the hypotenuse of a right
 *                  triangle. Second one takes two sides and returns the area
 *                  of a right triangle. The third one takes two angles and returns
 *                  the missing angle of a right triangle. These methods are used in
 *                  the TriangleForm.cs.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleUI
{
    public class Triangle
    {
        /// <summary>
        /// FindHypotenuseOfRight()
        /// </summary>
        /// <param>
        /// double side1, double side2
        /// </param>
        /// <desc>
        /// This method takes two sides and calculates the hypotenuse of
        /// a right triangle. Will return -1 if out of bounds.
        /// </desc>
        /// <returns>
        /// total
        /// </returns>
        public double FindHypotenuseOfRight(double side1, double side2)
        {
            double total;

                total = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

            if ((total <= 1) || (side1 <= 0) || (side2 <= 0))
                total = -1; // This is an error code. 

            return total;
        }

        /// <summary>
        /// FindAreaOfRight()
        /// </summary>
        /// <param>
        /// double side1, double side2
        /// </param>
        /// <desc>
        /// This method takes the two sides and calculates the area of
        /// a right triangle. Will return -1 if out of bounds.
        /// </desc>
        /// <returns>
        /// area
        /// </returns>
        public double FindAreaOfRight(double side1, double side2)
        {
            double area;

            area = 0.5 * (side1 * side2);

            if ((area <= 1) || (side1 <= 0) || (side2 <= 0))
                area = -1;

            return area;
        }

        /// <summary>
        /// FindMissingAngle()
        /// </summary>
        /// <param>
        /// double angle1, double angle2
        /// </param>
        /// <desc>
        /// This method takes the two angles and calculates the last angle of
        /// a right triangle. Will return -1 if out of bounds.
        /// </desc>
        /// <returns>
        /// angle3
        /// </returns>
        public double FindMissingAngle(double angle1, double angle2)
        {
            double angle3;

            angle3 = 180 - (angle1 + angle2);

            if ((angle3 > 180) || (angle3 <= 0) || (angle1 <= 0) || (angle2 <= 0))
                angle3 = -1;

            return angle3;
        }
    }
}

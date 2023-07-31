using System;
namespace _27._07._2023
{
	public class Course
	{
		public string Name;
		public Group[] Groups;



        public Course()
        {

        }
        public void AddGroup( Group group) {

            Group[] Groups = new Group[0];
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
            
           

        }
        public string GetGroupByNo(string no)
        {


            for (int i = 0; i < Groups.Length; i++)
            {
                if (Groups[i].No == no)
                {
                    return Groups[i].No;
                }
            }
            return "Bele bir qrup yoxdur";
        }
        public void GetGroupsByPointRange(double minPoint, double maxPoint,double avgPoint)
        {
            //if(avgPoint>minPoint && avgPoint < maxPoint)
            //{
            //    Console.WriteLine(Group);
            //}
        }
    }
}


namespace DemoAPI.Models
{
    public class Demo
    {
        public Demo(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("Id=[{0}], Name=[{1}]", Id, Name);
        }
    }
}

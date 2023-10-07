	public class PoligonalModel
    {
        public Poligon[] Poligons;
        public Texture[] Textures;
    }

    public class Poligon
    {
        public Point3D[] Points;
    }

    public class Texture
    {

    }

    public class Scene
    {
        public Int Id;
        public PoligonalModel[] Models;
        public Flash[] Flashes;

        public Type method1(Type t)
        {
            return null;
        }

        public Type method2(Type t, Type tt)
        {
            return null;
        }
    }

    public class Flash
    {
        public Point3D Location;
        public Angle3D Angle;
        public Color Color;
        public Float Power;

        public void Rotate(Angle3D angle)
        {

        }

        public void Move(Point3D point)
        {

        }
    }

    public class Camera
    {
        public Point3D Location;
        public Angle3D Angle;

        public void Rotate(Angle3D angle)
        {

        }

        public void Move(Point3D point)
        {

        }
    }
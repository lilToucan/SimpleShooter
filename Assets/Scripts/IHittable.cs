public interface IHittable
{
    float hp { get; set; }

    void TakeDmg(float _dmg);
}
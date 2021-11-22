namespace Votorantim.Domain.Aggregates.Docks.Enums
{
    public enum Direction
    {
        Right,
        Left,
        Front
    }

    public static class DirectionExtensions
    {
        public static string GetString(this Direction me)
        {
            return me switch
            {
                Direction.Right => "Vire à Direita",
                Direction.Left => "Vire à Esquerda",
                Direction.Front => "Siga em Frente",
                _ => "Sem Direção",
            };
        }
    }
}

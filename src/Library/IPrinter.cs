/// <summary>
/// Aplico polimorfismo y creo esta interfaz para evitar preguntar por el destino de la impresion,
/// cada clase del tipo IPrinter tiene la responsabilidad de imprimir la receta de una forma diferente.
/// Lo cual significa que PrintRecipe se transformo en una operacion polimorfica.
/// </summary>
namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}
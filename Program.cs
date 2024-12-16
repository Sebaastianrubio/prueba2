public class Producto
{
    // Propiedades del producto
    public int Id { get; set; }                // Identificador único
    public string Nombre { get; set; }         // Nombre del producto
    public string Unidad { get; set; }         // Unidad de medida (e.g., Kg, Litro)
    public decimal[] Precios { get; set; }     // Arreglo para almacenar los tres precios

    // Constructor para inicializar el producto
    public Producto(int id, string nombre, string unidad, decimal[] precios)
    {
        if (precios.Length != 3)
        {
            throw new ArgumentException("Debe ingresar exactamente 3 precios.");
        }

        Id = id;
        Nombre = nombre;
        Unidad = unidad;
        Precios = precios;
    }

    // Método para mostrar información del producto
    public override string ToString()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Unidad: {Unidad}, Precios: {string.Join(", ", Precios)}";
    }
}

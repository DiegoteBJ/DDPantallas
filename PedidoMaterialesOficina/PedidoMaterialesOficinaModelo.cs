using System;
using System.Collections.Generic;
using System.Text;

namespace DDPantallas.PedidoMaterialesOficina;

internal class PedidoMaterialesOficinaModelo
{
    private List<MaterialSolicitado> materialesSolicitados = new();

    public List<Material> Materiales
    {
        get
        {
            return new List<Material>
            {
                new Material { Id = 1, Descripcion = "Lapicero" },
                new Material { Id = 2, Descripcion = "Cuaderno" },
                new Material { Id = 3, Descripcion = "Goma de borrar" },
                new Material { Id = 4, Descripcion = "Regla" },
                new Material { Id = 5, Descripcion = "Marcadores" }
            };
        }
    }

    internal bool Agregar(MaterialSolicitado materialSeleccionado)
    {
        //Acá si, todas las validaciones que consideremos necesarias y sean posibles ahora.
        if (materialSeleccionado.Cantidad <= 0)
        {
            MessageBox.Show("La cantidad debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (string.IsNullOrWhiteSpace(materialSeleccionado.DescripcionAdicional))
        {
            MessageBox.Show("La descripción adicional no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        foreach (var materialYASeleccionad in materialesSolicitados)
        {
            if (materialYASeleccionad.MaterialId == materialSeleccionado.MaterialId)
            {
                MessageBox.Show("Este material ya ha sido seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //etc....
        materialesSolicitados.Add(materialSeleccionado);
        return true;
    }

    internal void Deseleccionar(int materialId)
    {
        foreach(var materialSeleccionado in materialesSolicitados)
        {
            if (materialSeleccionado.MaterialId == materialId)
            {
                materialesSolicitados.Remove(materialSeleccionado);
                return;
            }
        }

        //no puede llegar acá porque materialId es siempre válido, así que no me preocupo.
    }
}

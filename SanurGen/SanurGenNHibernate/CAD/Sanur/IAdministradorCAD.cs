
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (int idUsuario);

int New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (int idUsuario);


AdministradorEN ReadOID (int idUsuario);


System.Collections.Generic.IList<AdministradorEN> ReadAll (int first, int size);
}
}

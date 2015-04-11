
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IAdministrativoCAD
{
AdministrativoEN ReadOIDDefault (int idUsuario);

int New_ (AdministrativoEN administrativo);

void Modify (AdministrativoEN administrativo);


void Destroy (int idUsuario);


AdministrativoEN ReadOID (int idUsuario);


System.Collections.Generic.IList<AdministrativoEN> ReadAll (int first, int size);
}
}

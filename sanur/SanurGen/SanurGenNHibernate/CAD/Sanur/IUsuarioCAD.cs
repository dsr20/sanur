
using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int idUsuario);

UsuarioEN ReadOID (int idUsuario);


System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size);


int New_ (UsuarioEN usuario);


SanurGenNHibernate.EN.Sanur.UsuarioEN ReadMail (string p_mail);
}
}

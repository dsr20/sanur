
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using SanurGenNHibernate.EN.Sanur;
using SanurGenNHibernate.CAD.Sanur;

namespace SanurGenNHibernate.CEN.Sanur
{
public partial class UsuarioCEN
{
public bool ComprobarMail (string p_mail, string p_pass)
{
        /*PROTECTED REGION ID(SanurGenNHibernate.CEN.Sanur_Usuario_comprobarMail) ENABLED START*/

        UsuarioEN usuarioEN = null;
        bool login = false;


        if (p_mail != null && p_pass != null) {
                usuarioEN = _IUsuarioCAD.ReadMail (p_mail);

                if (usuarioEN != null) 
                {
                    if (usuarioEN.Contrasena == p_pass)
                        login = true;
                }
                else
                {
                    login = false;
                }
        }

        return login;
        /*PROTECTED REGION END*/
}
}
}


using System;
using SanurGenNHibernate.EN.Sanur;

namespace SanurGenNHibernate.CAD.Sanur
{
public partial interface IAdjuntoCAD
{
AdjuntoEN ReadOIDDefault (int idAdjunto);

int New_ (AdjuntoEN adjunto);

void Modify (AdjuntoEN adjunto);


void Destroy (int idAdjunto);


AdjuntoEN ReadOID (int idAdjunto);


System.Collections.Generic.IList<AdjuntoEN> ReadAll (int first, int size);
}
}

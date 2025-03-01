﻿namespace CakeMachine.Fabrication.Paramètres
{
    internal record ParamètresUsine(
        ushort NombrePréparateurs, 
        ushort NombreFours, 
        ushort NombreEmballeuses,
        ParamètresPréparation ParamètresPréparation,
        ParamètresCuisson ParamètresCuisson,
        ParamètresEmballage ParamètresEmballage);
}

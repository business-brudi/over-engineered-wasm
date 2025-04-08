﻿using Brudibytes.Core.Contract.DependencyInjection;

namespace Diamond.Vertical.ComponentMapping;

public class ComponentMap : IComponentMap
{
    public void Initialize(ICoCoKernel kernel)
    {
        InitializeUi(kernel);
        InitializeDomainLogic(kernel);
    }

    private void InitializeUi(ICoCoKernel kernel)
    {
        kernel.RegisterComponent<Diamond.Ui.Weather.Activator>();
    }

    private void InitializeDomainLogic(ICoCoKernel kernel)
    {
        kernel.RegisterComponent<Logic.Domain.Weather.Activator>();
    }
}

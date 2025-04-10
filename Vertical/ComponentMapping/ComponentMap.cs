﻿using Brudibytes.Core.Contract.DependencyInjection;

namespace Diamond.Vertical.ComponentMapping;

public class ComponentMap : IComponentMap
{
    public void Initialize(ICoCoKernel kernel)
    {
        InitializeUi(kernel);
        InitializeDomainLogic(kernel);
        InitializeViewModel(kernel);
        InitializeData(kernel);
    }

    private void InitializeData(ICoCoKernel kernel)
    {
        kernel.RegisterComponent<Diamond.Data.Weather.Http.OpenMeteo.Activator>();
    }

    private void InitializeViewModel(ICoCoKernel kernel)
    {
        kernel.RegisterComponent<Diamond.Logic.ViewModel.Weather.ViewModel.Activator>();
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

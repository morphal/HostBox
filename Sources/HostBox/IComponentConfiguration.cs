﻿using System;

using HostShim;

namespace HostBox
{
    /// <summary>
    /// Конфигурация компонента приложения. 
    /// Используется для управления ходом выполнения компонента.
    /// </summary>
    public interface IComponentConfiguration
    {
        /// <summary>
        /// Домен приложения загружаемого компонента.
        /// Используется в случае, когда компонент загружается в независимый от основного приложения домен приложения.
        /// В случае загрузки в основной домен приложения, может быть либо <c>null</c>, либо равен основному домену приложения.
        /// </summary>
        AppDomain ComponentDomain { get; set; }

        /// <summary>
        /// Загружаемый компонент приложения.
        /// Используется для управления компонентом.
        /// Отвечает за загрузку исполняемого кода компонента в домен приложений.
        /// </summary>
        IComponent Component { get; set; }
    }
}
﻿using System.Collections.Generic;
using Intent.Modules.Common.Templates;
using Intent.Templates;

namespace Intent.Modules.Common.CSharp.DependencyInjection
{
    public class ContainerRegistrationRequest
    {
        private readonly List<ITemplateDependency> _templateDependencies = new List<ITemplateDependency>();
        private readonly List<string> _requiredNamespaces = new List<string>();

        private ContainerRegistrationRequest(IClassProvider concreteType)
        {
            ConcreteType = concreteType.FullTypeName();
            Lifetime = LifeTime.Transient;
            _templateDependencies.Add(TemplateDependency.OnTemplate(concreteType));
        }

        private ContainerRegistrationRequest(string concreteType)
        {
            ConcreteType = concreteType;
            Lifetime = LifeTime.Transient;
        }

        public static ContainerRegistrationRequest ToRegister(IClassProvider concreteType)
        {
            return new ContainerRegistrationRequest(concreteType);
        }

        public static ContainerRegistrationRequest ToRegister(string concreteType)
        {
            return new ContainerRegistrationRequest(concreteType);
        }

        public ContainerRegistrationRequest ForInterface(IClassProvider interfaceType)
        {
            InterfaceType = interfaceType.FullTypeName();
            _templateDependencies.Add(TemplateDependency.OnTemplate(interfaceType));
            return this;
        }

        public ContainerRegistrationRequest ForInterface(string interfaceType)
        {
            InterfaceType = interfaceType;
            return this;
        }

        public ContainerRegistrationRequest ForConcern(string concern)
        {
            Concern = concern;
            return this;
        }

        public ContainerRegistrationRequest WithLifeTime(string lifetime)
        {
            Lifetime = lifetime;
            return this;
        }

        public ContainerRegistrationRequest WithPerServiceCallLifeTime()
        {
            Lifetime = LifeTime.PerServiceCall;
            return this;
        }

        public ContainerRegistrationRequest WithSingletonLifeTime()
        {
            Lifetime = LifeTime.Singleton;
            return this;
        }

        public ContainerRegistrationRequest WithResolveFromContainer()
        {
            ResolveFromContainer = true;
            return this;
        }

        public ContainerRegistrationRequest RequiresUsingNamespaces(params string[] namespaces)
        {
            _requiredNamespaces.AddRange(namespaces);
            return this;
        }

        public ContainerRegistrationRequest HasDependency(ITemplate template)
        {
            _templateDependencies.Add(TemplateDependency.OnTemplate(template));
            return this;
        }

        public ContainerRegistrationRequest WithPriority(int priority)
        {
            Priority = priority;
            return this;
        }

        public void MarkAsHandled()
        {
            IsHandled = true;
        }

        public IEnumerable<string> RequiredNamespaces => _requiredNamespaces;

        public string Concern { get; private set; }

        public string InterfaceType { get; private set; }

        public string ConcreteType { get; }

        public string Lifetime { get; private set; }

        public int Priority { get; private set; }

        public bool ResolveFromContainer { get; private set; }

        public IEnumerable<ITemplateDependency> TemplateDependencies => _templateDependencies;

        public bool IsHandled { get; private set; }

        public static class LifeTime
        {
            public const string Transient = "Transient";
            public const string Singleton = "Singleton";
            public const string PerServiceCall = "PerServiceCall";
        }
    }
}
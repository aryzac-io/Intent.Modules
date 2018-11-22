﻿using Intent.SoftwareFactory.Engine;
using Intent.SoftwareFactory.Registrations;
using System;
using Intent.Modules.Entities.Templates.DomainEntityState;

namespace Intent.Modules.Entities.Decorators
{
    public class DefaultConstructorDomainEntityDecoratorRegistration : DecoratorRegistration<DomainEntityStateDecoratorBase>
    {
        public override string DecoratorId => DefaultConstructorDomainEntityDecorator.Identifier;

        public override object CreateDecoratorInstance(IApplication application)
        {
            return new DefaultConstructorDomainEntityDecorator();
        }
    }
}
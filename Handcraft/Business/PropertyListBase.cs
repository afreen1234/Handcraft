﻿using EPiServer.Core;
using EPiServer.Framework.Serialization;
using EPiServer.Framework.Serialization.Internal;
using EPiServer.ServiceLocation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handcraft.Business
{
    public class PropertyListBase<T> : PropertyList<T>
    {
        public PropertyListBase()
        {
            _objectSerializer = this._objectSerializerFactory.Service.GetSerializer("application/json");
        }
        private Injected<ObjectSerializerFactory> _objectSerializerFactory;

        private IObjectSerializer _objectSerializer;

        protected override T ParseItem(string value)
        {
            return _objectSerializer.Deserialize<T>(value);
        }

        public override PropertyData ParseToObject(string value)
        {
            ParseToSelf(value);
            return this;
        }
    }
}
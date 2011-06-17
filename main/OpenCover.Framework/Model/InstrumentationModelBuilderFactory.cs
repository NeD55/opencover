﻿//
// OpenCover - S Wilde
//
// This source code is released under the MIT License; see the accompanying license file.
//
using OpenCover.Framework.Symbols;

namespace OpenCover.Framework.Model
{
    public class InstrumentationModelBuilderFactory : IInstrumentationModelBuilderFactory
    {
        private readonly ISymbolManagerFactory _symbolManagerFactory;

        public InstrumentationModelBuilderFactory(ISymbolManagerFactory symbolManagerFactory)
        {
            _symbolManagerFactory = symbolManagerFactory;
        }

        public IInstrumentationModelBuilder CreateModelBuilder(string moduleName)
        {
            var manager = _symbolManagerFactory.CreateSymbolManager(moduleName);
            return new InstrumentationModelBuilder(manager);
        }
    }
}
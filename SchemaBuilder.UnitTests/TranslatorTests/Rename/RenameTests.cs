﻿using SchemaBuilder.Tests.Unit.SharedKernel;
using SchemaBuilder.Translator.Implementations;
using Xunit;

namespace SchemaBuilder.Tests.Unit.TranslatorTests.Rename
{
    public class RenameTests
    {
        [Fact]
        public void ShouldRenameTable()
        {
            //Execution 
            string script = new ScriptTranslator(new RenameTableMock()).Translate();

            //Assertions
            Assert.NotNull(script);
            Assert.Equal("EXEC SP_RENAME 'Customer', 'Client';\n", script);
        }

        [Fact]
        public void ShouldRenameColumn()
        {
            //Execution 
            string script = new ScriptTranslator(new RenameColumnMock()).Translate();

            //Assertions
            Assert.NotNull(script);
            Assert.Equal("EXEC SP_RENAME 'Customer.Id', 'Ide', 'COLUMN';\n", script);
        }
    }
}

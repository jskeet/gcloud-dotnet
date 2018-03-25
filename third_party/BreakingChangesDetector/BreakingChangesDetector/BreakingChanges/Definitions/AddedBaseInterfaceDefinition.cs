﻿/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.
    Copyright 2018 Google LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using BreakingChangesDetector.MetadataItems;
using Microsoft.CodeAnalysis;

namespace BreakingChangesDetector.BreakingChanges.Definitions
{
    internal class AddedBaseInterfaceDefinition : BreakingChangeDefinitionBase
    {
        public static readonly AddedBaseInterfaceDefinition Instance = new AddedBaseInterfaceDefinition();

        private AddedBaseInterfaceDefinition() { }

        public override void CompareItems(CompareItemsContext context)
        {
            var oldType = (TypeDefinitionData)context.OldItem;
            var newType = (TypeDefinitionData)context.NewItem;

            if (oldType.TypeKind != TypeKind.Interface)
            {
                return;
            }

            foreach (var newInterfaceType in newType.ImplementedInterfaces)
            {
                if (newInterfaceType.HasMembers == false)
                {
                    continue;
                }

                var hasNewInterfaceEquivalent = false;
                foreach (var oldInterfaceType in oldType.ImplementedInterfaces)
                {
                    if (oldInterfaceType.IsEquivalentToNew(newInterfaceType, context.NewAssemblyFamily))
                    {
                        hasNewInterfaceEquivalent = true;
                        break;
                    }
                }

                if (hasNewInterfaceEquivalent == false)
                {
                    context.BreakingChanges.Add(new AddedBaseInterface(oldType, newType, newInterfaceType));
                }
            }
        }

        public override BreakingChangeKind BreakingChangeKind =>
            BreakingChangeKind.AddedBaseInterface;

        public override MetadataItemKinds MembersKindsHandled =>
            MetadataItemKinds.TypeDefinition;
    }
}

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

namespace BreakingChangesDetector.BreakingChanges.Definitions
{
    internal class ChangedParameterNameDefinition : BreakingChangeDefinitionBase
    {
        public static readonly ChangedParameterNameDefinition Instance = new ChangedParameterNameDefinition();

        private ChangedParameterNameDefinition() { }

        public override void CompareItems(CompareItemsContext context)
        {
            var oldParameter = (ParameterData)context.OldItem;
            var newParameter = (ParameterData)context.NewItem;

            if (oldParameter.DeclaringMemberKind != MetadataItemKinds.Operator && oldParameter.Name != newParameter.Name)
            {
                context.BreakingChanges.Add(new ChangedParameterName(oldParameter, newParameter, (IParameterizedItem)context.AdditionalInfo));
            }
        }

        public override BreakingChangeKind BreakingChangeKind =>
            BreakingChangeKind.ChangedParameterName;

        public override MetadataItemKinds MembersKindsHandled =>
            MetadataItemKinds.Parameter;
    }
}

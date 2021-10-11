// ***********************************************************************
// Assembly         : OpenAC.Net.DFe.Core
// Author           : RFTD
// Created          : 07-24-2016
//
// Last Modified By : RFTD
// Last Modified On : 07-24-2016
// ***********************************************************************
// <copyright file="DFeTipoAmbiente.cs" company="OpenAC .Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo OpenAC.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using OpenAC.Net.DFe.Core.Attributes;
using System.ComponentModel;

namespace OpenAC.Net.DFe.Core.Common
{
    /// <summary>
    ///     Identifica��o do Ambiente
    ///     <para>1 - Produ��o</para>
    ///     <para>2 - Homologa��o</para>
    /// </summary>

    public enum DFeTipoAmbiente : byte
    {
        /// <summary>
        /// Produ��o
        /// </summary>
        [DFeEnum("1")]
        [Description("Produ��o")]
        Producao = 1,

        /// <summary>
        /// Homologa��o
        /// </summary>
        [DFeEnum("2")]
        [Description("Homologa��o")]
        Homologacao = 2
    }
}
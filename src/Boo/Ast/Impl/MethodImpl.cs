#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// As a special exception, if you link this library with other files to
// produce an executable, this library does not by itself cause the
// resulting executable to be covered by the GNU General Public License.
// This exception does not however invalidate any other reasons why the
// executable file might be covered by the GNU General Public License.
//
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by the
// ast.py script on Mon Jan 12 19:25:25 2004
//
using System;

namespace Boo.Ast.Impl
{
	[Serializable]
	public abstract class MethodImpl : TypeMember
	{
		protected ParameterDeclarationCollection _parameters;
		protected TypeReference _returnType;
		protected AttributeCollection _returnTypeAttributes;
		protected Block _body;
		protected LocalCollection _locals;
		
		protected MethodImpl()
		{
			_parameters = new ParameterDeclarationCollection(this);
			_returnTypeAttributes = new AttributeCollection(this);
			Body = new Block();
 		}
		
		protected MethodImpl(TypeReference returnType)
		{
			_parameters = new ParameterDeclarationCollection(this);
			_returnTypeAttributes = new AttributeCollection(this);
			Body = new Block();
 			ReturnType = returnType;
		}
		
		protected MethodImpl(antlr.Token token, TypeReference returnType) : base(token)
		{
			_parameters = new ParameterDeclarationCollection(this);
			_returnTypeAttributes = new AttributeCollection(this);
			Body = new Block();
 			ReturnType = returnType;
		}
		
		internal MethodImpl(antlr.Token token) : base(token)
		{
			_parameters = new ParameterDeclarationCollection(this);
			_returnTypeAttributes = new AttributeCollection(this);
			Body = new Block();
 		}
		
		internal MethodImpl(Node lexicalInfoProvider) : base(lexicalInfoProvider)
		{
			_parameters = new ParameterDeclarationCollection(this);
			_returnTypeAttributes = new AttributeCollection(this);
			Body = new Block();
 		}
		
		public override NodeType NodeType
		{
			get
			{
				return NodeType.Method;
			}
		}
		public ParameterDeclarationCollection Parameters
		{
			get
			{
				return _parameters;
			}
			
			set
			{
				
				if (_parameters != value)
				{
					_parameters = value;
					if (null != _parameters)
					{
						_parameters.InitializeParent(this);
					}
				}
			}
		}
		public TypeReference ReturnType
		{
			get
			{
				return _returnType;
			}
			
			set
			{
				
				if (_returnType != value)
				{
					_returnType = value;
					if (null != _returnType)
					{
						_returnType.InitializeParent(this);
					}
				}
			}
		}
		public AttributeCollection ReturnTypeAttributes
		{
			get
			{
				return _returnTypeAttributes;
			}
			
			set
			{
				
				if (_returnTypeAttributes != value)
				{
					_returnTypeAttributes = value;
					if (null != _returnTypeAttributes)
					{
						_returnTypeAttributes.InitializeParent(this);
					}
				}
			}
		}
		public Block Body
		{
			get
			{
				return _body;
			}
			
			set
			{
				
				if (_body != value)
				{
					_body = value;
					if (null != _body)
					{
						_body.InitializeParent(this);
					}
				}
			}
		}
		[System.Xml.Serialization.XmlIgnore]
		public LocalCollection Locals
		{
			get
			{
				if (null == _locals)
				{
					_locals = new LocalCollection(this);
				}
				return _locals;
			}
		}
		public override void Switch(IAstTransformer transformer, out Node resultingNode)
		{
			Method thisNode = (Method)this;
			Method resultingTypedNode = thisNode;
			transformer.OnMethod(thisNode, ref resultingTypedNode);
			resultingNode = resultingTypedNode;
		}
	}
}

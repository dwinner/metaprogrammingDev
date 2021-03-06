//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace Company.DSLSample
{
	/// <summary>
	/// DomainRelationship ExampleModelHasElements
	/// Embedding relationship between the Model and Elements
	/// </summary>
	[DslDesign::DisplayNameResource("Company.DSLSample.ExampleModelHasElements.DisplayName", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.DSLSample.ExampleModelHasElements.Description", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Company.DSLSample.DSLSampleDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("0746d3a3-184f-48e1-a600-5d12e2d11ecd")]
	public partial class ExampleModelHasElements : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ExampleModelHasElements domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x0746d3a3, 0x184f, 0x48e1, 0xa6, 0x00, 0x5d, 0x12, 0xe2, 0xd1, 0x1e, 0xcd);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ExampleModelHasElements link in the same Partition as the given ExampleModel
		/// </summary>
		/// <param name="source">ExampleModel to use as the source of the relationship.</param>
		/// <param name="target">ExampleElement to use as the target of the relationship.</param>
		public ExampleModelHasElements(ExampleModel source, ExampleElement target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ExampleModelHasElements.ExampleModelDomainRoleId, source), new DslModeling::RoleAssignment(ExampleModelHasElements.ElementDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleModelHasElements(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleModelHasElements(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleModelHasElements(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleModelHasElements(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region ExampleModel domain role code
		
		/// <summary>
		/// ExampleModel domain role Id.
		/// </summary>
		public static readonly global::System.Guid ExampleModelDomainRoleId = new global::System.Guid(0x235503b5, 0x657d, 0x4b6f, 0x81, 0x00, 0xe8, 0x23, 0x28, 0xe3, 0x0c, 0x36);
		
		/// <summary>
		/// DomainRole ExampleModel
		/// </summary>
		[DslDesign::DisplayNameResource("Company.DSLSample.ExampleModelHasElements/ExampleModel.DisplayName", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Company.DSLSample.ExampleModelHasElements/ExampleModel.Description", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Elements", PropertyDisplayNameKey="Company.DSLSample.ExampleModelHasElements/ExampleModel.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("235503b5-657d-4b6f-8100-e82328e30c36")]
		public virtual ExampleModel ExampleModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleModel)DslModeling::DomainRoleInfo.GetRolePlayer(this, ExampleModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ExampleModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access ExampleModel of a ExampleElement
		/// <summary>
		/// Gets ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static ExampleModel GetExampleModel(ExampleElement element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, ElementDomainRoleId) as ExampleModel;
		}
		
		/// <summary>
		/// Sets ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetExampleModel(ExampleElement element, ExampleModel newExampleModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, ElementDomainRoleId, newExampleModel);
		}
		#endregion
		#region Element domain role code
		
		/// <summary>
		/// Element domain role Id.
		/// </summary>
		public static readonly global::System.Guid ElementDomainRoleId = new global::System.Guid(0x85419d29, 0x40c3, 0x428f, 0xba, 0x04, 0x70, 0x4b, 0x01, 0xc1, 0x43, 0x71);
		
		/// <summary>
		/// DomainRole Element
		/// </summary>
		[DslDesign::DisplayNameResource("Company.DSLSample.ExampleModelHasElements/Element.DisplayName", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Company.DSLSample.ExampleModelHasElements/Element.Description", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "ExampleModel", PropertyDisplayNameKey="Company.DSLSample.ExampleModelHasElements/Element.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("85419d29-40c3-428f-ba04-704b01c14371")]
		public virtual ExampleElement Element
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, ElementDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ElementDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Elements of a ExampleModel
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetElements(ExampleModel element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, ExampleModelDomainRoleId);
		}
		#endregion
		#region ExampleModel link accessor
		/// <summary>
		/// Get the list of ExampleModelHasElements links to a ExampleModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Company.DSLSample.ExampleModelHasElements> GetLinksToElements ( global::Company.DSLSample.ExampleModel exampleModelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleModelHasElements>(exampleModelInstance, global::Company.DSLSample.ExampleModelHasElements.ExampleModelDomainRoleId);
		}
		#endregion
		#region Element link accessor
		/// <summary>
		/// Get the ExampleModelHasElements link to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Company.DSLSample.ExampleModelHasElements GetLinkToExampleModel (global::Company.DSLSample.ExampleElement elementInstance)
		{
			global::System.Collections.Generic.IList<global::Company.DSLSample.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleModelHasElements>(elementInstance, global::Company.DSLSample.ExampleModelHasElements.ElementDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Element not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region ExampleModelHasElements instance accessors
		
		/// <summary>
		/// Get any ExampleModelHasElements links between a given ExampleModel and a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Company.DSLSample.ExampleModelHasElements> GetLinks( global::Company.DSLSample.ExampleModel source, global::Company.DSLSample.ExampleElement target )
		{
			global::System.Collections.Generic.List<global::Company.DSLSample.ExampleModelHasElements> outLinks = new global::System.Collections.Generic.List<global::Company.DSLSample.ExampleModelHasElements>();
			global::System.Collections.Generic.IList<global::Company.DSLSample.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleModelHasElements>(source, global::Company.DSLSample.ExampleModelHasElements.ExampleModelDomainRoleId);
			foreach ( global::Company.DSLSample.ExampleModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ExampleModelHasElements link between a given ExampleModeland a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Company.DSLSample.ExampleModelHasElements GetLink( global::Company.DSLSample.ExampleModel source, global::Company.DSLSample.ExampleElement target )
		{
			global::System.Collections.Generic.IList<global::Company.DSLSample.ExampleModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleModelHasElements>(source, global::Company.DSLSample.ExampleModelHasElements.ExampleModelDomainRoleId);
			foreach ( global::Company.DSLSample.ExampleModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Company.DSLSample
{
	/// <summary>
	/// DomainRelationship ExampleElementReferencesTargets
	/// Reference relationship between Elements.
	/// </summary>
	[DslDesign::DisplayNameResource("Company.DSLSample.ExampleElementReferencesTargets.DisplayName", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Company.DSLSample.ExampleElementReferencesTargets.Description", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Company.DSLSample.DSLSampleDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship()]
	[DslModeling::DomainObjectId("7c717922-aee5-4a8c-980c-acd2ae580c90")]
	public partial class ExampleElementReferencesTargets : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// ExampleElementReferencesTargets domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x7c717922, 0xaee5, 0x4a8c, 0x98, 0x0c, 0xac, 0xd2, 0xae, 0x58, 0x0c, 0x90);
	
				
		/// <summary>
		/// Constructor
		/// Creates a ExampleElementReferencesTargets link in the same Partition as the given ExampleElement
		/// </summary>
		/// <param name="source">ExampleElement to use as the source of the relationship.</param>
		/// <param name="target">ExampleElement to use as the target of the relationship.</param>
		public ExampleElementReferencesTargets(ExampleElement source, ExampleElement target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(ExampleElementReferencesTargets.SourceDomainRoleId, source), new DslModeling::RoleAssignment(ExampleElementReferencesTargets.TargetDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleElementReferencesTargets(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleElementReferencesTargets(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public ExampleElementReferencesTargets(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public ExampleElementReferencesTargets(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Source domain role code
		
		/// <summary>
		/// Source domain role Id.
		/// </summary>
		public static readonly global::System.Guid SourceDomainRoleId = new global::System.Guid(0xf5232675, 0x5c00, 0x4291, 0x86, 0x5b, 0xd0, 0x5f, 0x25, 0x33, 0x6e, 0x2d);
		
		/// <summary>
		/// DomainRole Source
		/// Description for Company.DSLSample.ExampleRelationship.Target
		/// </summary>
		[DslDesign::DisplayNameResource("Company.DSLSample.ExampleElementReferencesTargets/Source.DisplayName", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Company.DSLSample.ExampleElementReferencesTargets/Source.Description", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Targets", PropertyDisplayNameKey="Company.DSLSample.ExampleElementReferencesTargets/Source.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("f5232675-5c00-4291-865b-d05f25336e2d")]
		public virtual ExampleElement Source
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, SourceDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, SourceDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Sources of a ExampleElement
		/// <summary>
		/// Gets a list of Sources.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetSources(ExampleElement element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, TargetDomainRoleId);
		}
		#endregion
		#region Target domain role code
		
		/// <summary>
		/// Target domain role Id.
		/// </summary>
		public static readonly global::System.Guid TargetDomainRoleId = new global::System.Guid(0x675f8330, 0xd5f2, 0x475f, 0xa4, 0x3d, 0xd3, 0x7f, 0x1a, 0x1d, 0x59, 0xfd);
		
		/// <summary>
		/// DomainRole Target
		/// Description for Company.DSLSample.ExampleRelationship.Source
		/// </summary>
		[DslDesign::DisplayNameResource("Company.DSLSample.ExampleElementReferencesTargets/Target.DisplayName", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Company.DSLSample.ExampleElementReferencesTargets/Target.Description", typeof(global::Company.DSLSample.DSLSampleDomainModel), "Company.DSLSample.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Sources", PropertyDisplayNameKey="Company.DSLSample.ExampleElementReferencesTargets/Target.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("675f8330-d5f2-475f-a43d-d37f1a1d59fd")]
		public virtual ExampleElement Target
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (ExampleElement)DslModeling::DomainRoleInfo.GetRolePlayer(this, TargetDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, TargetDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Targets of a ExampleElement
		/// <summary>
		/// Gets a list of Targets.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<ExampleElement> GetTargets(ExampleElement element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<ExampleElement>, ExampleElement>(element, SourceDomainRoleId);
		}
		#endregion
		#region Source link accessor
		/// <summary>
		/// Get the list of ExampleElementReferencesTargets links to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Company.DSLSample.ExampleElementReferencesTargets> GetLinksToTargets ( global::Company.DSLSample.ExampleElement sourceInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleElementReferencesTargets>(sourceInstance, global::Company.DSLSample.ExampleElementReferencesTargets.SourceDomainRoleId);
		}
		#endregion
		#region Target link accessor
		/// <summary>
		/// Get the list of ExampleElementReferencesTargets links to a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Company.DSLSample.ExampleElementReferencesTargets> GetLinksToSources ( global::Company.DSLSample.ExampleElement targetInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleElementReferencesTargets>(targetInstance, global::Company.DSLSample.ExampleElementReferencesTargets.TargetDomainRoleId);
		}
		#endregion
		#region ExampleElementReferencesTargets instance accessors
		
		/// <summary>
		/// Get any ExampleElementReferencesTargets links between a given ExampleElement and a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Company.DSLSample.ExampleElementReferencesTargets> GetLinks( global::Company.DSLSample.ExampleElement source, global::Company.DSLSample.ExampleElement target )
		{
			global::System.Collections.Generic.List<global::Company.DSLSample.ExampleElementReferencesTargets> outLinks = new global::System.Collections.Generic.List<global::Company.DSLSample.ExampleElementReferencesTargets>();
			global::System.Collections.Generic.IList<global::Company.DSLSample.ExampleElementReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleElementReferencesTargets>(source, global::Company.DSLSample.ExampleElementReferencesTargets.SourceDomainRoleId);
			foreach ( global::Company.DSLSample.ExampleElementReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one ExampleElementReferencesTargets link between a given ExampleElementand a ExampleElement.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Company.DSLSample.ExampleElementReferencesTargets GetLink( global::Company.DSLSample.ExampleElement source, global::Company.DSLSample.ExampleElement target )
		{
			global::System.Collections.Generic.IList<global::Company.DSLSample.ExampleElementReferencesTargets> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Company.DSLSample.ExampleElementReferencesTargets>(source, global::Company.DSLSample.ExampleElementReferencesTargets.SourceDomainRoleId);
			foreach ( global::Company.DSLSample.ExampleElementReferencesTargets link in links )
			{
				if ( target.Equals(link.Target) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}

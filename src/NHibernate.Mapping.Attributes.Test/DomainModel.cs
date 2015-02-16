//
// NHibernate.Mapping.Attributes.Test
// This product is under the terms of the GNU Lesser General Public License.
//
using System;
using System.Runtime.InteropServices;
//using System.Collections;
//using System.Collections.Specialized;
using NHMA = NHibernate.Mapping.Attributes;

/*\
 * The mapping used in the following classes has no meaning for NHibernate;
 * it is here for the sole purpose of testing NHibernate.Mapping.Attributes
 * in all possible usage cases.
\*/

namespace NHibernate.Mapping.Attributes.Test.DomainModel
{
	public class Bar { }
	public class Fee { }
	public class Foo { }
	public class FooComponent { }
	public interface IFooProxy { }

	[NHMA.Import(ClassType = typeof(double), Rename = "RealNumber")]
	[NHMA.Import(1, ClassType = typeof(Glarch))]
	public class Glarch { }

	class ReverseComparator { }


	/// <summary>
	/// POJO for Baz
	/// </summary>
	/// <remark>
	/// This class is autogenerated
	/// </remark>
	[Serializable]
	// Set <hibernate-mapping> attributes
	// Note: this attribute is used when you serialize this class (not the assembly)
	[NHMA.HibernateMapping(-1, DefaultLazy = true, DefaultCascade = "none", Schema = "Schema", DefaultAccessType = typeof(int), AutoImport = true, Namespace = "NH", Assembly = "NH")]
	[NHMA.Class(DiscriminatorValue = "base", NameType = typeof(Baz), Mutable = false, Polymorphism = NHMA.PolymorphismType.Explicit, ProxyType = typeof(Baz), PersisterType = typeof(Baz), BatchSize = 9, Check = "0", Where = "1")]
	public class Baz
	{
		#region NestingComponent + NestedBaz + Discriminator
		[NHMA.Component(-1, Name = "BazComponent", ClassType = typeof(NestingComponent), Update = false, Insert = false, AccessType = typeof(int))]
		public struct NestingComponent { }

		enum DiscEnum
		{
			Val0,
			Val1
		}

		[NHMA.Subclass(DiscriminatorValueEnumFormat = "d", DiscriminatorValueObject = DiscEnum.Val1, NameType = typeof(NestedBaz), ProxyType = typeof(NestedBaz), ExtendsType = typeof(Baz))]
		private class NestedBaz : Baz // Test access to private field (in a private nested class)
		{
			[NHMA.Array(0, Table = "bazcomponents", AccessType = typeof(int), OptimisticLock = true)]
			[NHMA.Key(1)]
			[NHMA.Column(2, Name = "baz_id", Length = 16)]
			[NHMA.Index(3, Column = "i")]
			[NHMA.CompositeElement(4, ClassType = typeof(FooComponent))]
			[NHMA.Parent(5, Name = "Baz", Access = "Random")]
			[NHMA.Property(6, Name = "Name", Length = 64, NotNull = false, UniqueKey = "something", Unique = false, Update = false, Insert = false, Formula = "Formula")]
			[NHMA.Column(7, Name = "name", Length = 56)]
			[NHMA.Type(8, NameType = typeof(bool))]
			[NHMA.Param(9, Name = "Property.Type1")]
			[NHMA.Param(10, Name = "Property.Type2", Content = "Content")]
			[NHMA.Property(11, Name = "Count", Column = "count_", TypeType = typeof(int))]
			[NHMA.NestedCompositeElement(12, Name = "Subcomponent", ClassType = typeof(FooComponent), AccessType = typeof(int))]
			[NHMA.Property(13, Name = "Name", Column = "x_")]
			[NHMA.Property(14, Name = "Count", Column = "y_", TypeType = typeof(int))]
			private System.Collections.Generic.IList<FooComponent> _list;


			[NHMA.DynamicComponent(AccessType = typeof(Foo))]
			// TODO: No longer supported:			[NHMA.ComponentProperty(1, ComponentType=typeof(CompAddress), PropertyName="CompPropAddress")]
			[NHMA.DynamicComponent(7, Name = "NestedDynComponent", Update = false, Insert = false, AccessType = typeof(int))]
			[NHMA.Property(8, Generated = PropertyGeneration.Insert)]
			// When ComponentProperty was a BaseAttribute: TODO: Not supported: (will be used by both [DynComp])
			//			[NHMA.ComponentProperty(9, ComponentType=typeof(CompAddress), PropertyName="LastAddress")]
			public System.Collections.Generic.IList<FooComponent> List
			{
				get { return _list; }
				set { _list = value; }
			}

			[NHMA.ComponentProperty()] // Auto-detection :)
			[NHMA.Join(-1, Table = "SubTable")]
			[NHMA.Key(1, Column = "SubKey")]
			public CompAddress MyAutoCompAddress
			{
				get { return null; }
				set { }
			}

			[NHMA.Loader(QueryRef = "queryRef")]
			[NHMA.SqlInsert(1, Content = "C")]
			[NHMA.SqlUpdate(2, Content = "U")]
			[NHMA.SqlDelete(3, Content = "D")]
			public int sql = 1;
		}
		#endregion

		#region Fields

		private NestingComponent _collectionComponent;
		private String _code;
		private FooComponent[] _components;
		private DateTime[] _timeArray;
		private string[] _stringArray;
		private int[] _intArray;
		private IFooProxy[] _fooArray;
		private Int32 _count;
		private String _name;
		private Foo _foo;
		private System.Collections.Generic.IList<Baz> _stringList;
		private System.Collections.Generic.IList<Fee> _fees;
		private System.Collections.Generic.IList<double> _customs;
		private System.Collections.Generic.IList<FooComponent> _topComponents;
		private System.Collections.Generic.IDictionary<Foo, Glarch> _fooToGlarch;
		private System.Collections.Generic.IDictionary<FooComponent, Foo> _fooComponentToFoo;
		private System.Collections.Generic.IDictionary<string, Glarch> _glarchToFoo;
		private System.Collections.Generic.IDictionary<Foo, DateTime> _stringDateMap;
		private System.Collections.Generic.IDictionary<char, Glarch> _topGlarchez;
		private System.Collections.Generic.IDictionary<Baz, FooComponent> _cachedMap;
		private System.Collections.Generic.IDictionary<Baz, FooComponent> _stringGlarchMap;
		private System.Collections.Generic.IDictionary<Int64, NestingComponent> _anyToAny;
		private System.Collections.Generic.IList<object> _manyToAny;
		private System.Collections.Generic.ISet<Foo> _fooSet;
		private System.Collections.Generic.ISet<string> _stringSet;
		private System.Collections.Generic.ISet<Foo> _topFoos;
		private System.Collections.Generic.ISet<Bar> _cascadingBars;
		private System.Collections.Generic.ISet<object> _cached;
		private System.Collections.Generic.ISet<object> _sortablez;
		private System.Collections.Generic.IList<string> _bag;
		private System.Collections.Generic.IList<string> _fooBag;
		private System.Collections.Generic.IList<Foo> _idFooBag;
		private System.Collections.Generic.IList<byte[]> _byteBag;
		private System.Collections.Generic.IList<int> _bazez;

		#endregion

		#region Constructors
		/// <summary>
		/// Default constructor for class Baz
		/// </summary>
		public Baz()
		{
		}


		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the _collectionComponent
		/// </summary>
		[NHMA.ManyToOne(NotNull = true, Index = "i", UniqueKey = "uk", Lazy = NHMA.Laziness.False, NotFound = NHMA.NotFoundMode.Ignore, ClassType = typeof(int), AccessType = typeof(Foo), Fetch = FetchMode.Select, OuterJoin = NHMA.OuterJoinStrategy.True)]
		public NestingComponent CollectionComponent
		{
			get
			{
				return _collectionComponent;
			}
			set
			{
				_collectionComponent = value;
			}
		}

		/// <summary>
		/// Get/set for Code
		/// </summary>
		[NHMA.Id(-4, Name = "Code", TypeType = typeof(string), Access = "field.camelcase-underscore", AccessType = typeof(int), Column = "Id", Length = 8, UnsavedValueObject = "null")]
		[NHMA.Column(-3, Name = "baz_id", Length = 32)]
		[NHMA.Generator(-2, Class = "uuid.hex")]
		[NHMA.Param(-1, Name = "property", Content = "Y")]
		[NHMA.Param(Name = "Unknow")] // Default to 0 :)
		[NHMA.Discriminator(1, Column = "clazz_discriminator", Formula = "1==2", TypeType = typeof(string), NotNull = true, Length = 256, Force = true, Insert = false)]
		public String Code
		{
			get
			{
				return this._code;
			}
			set
			{
				this._code = value;
			}
		}

		/// <summary>
		/// Get/set for count
		/// </summary>
		[NHMA.Version(Generated = VersionGeneration.Never, Column = "count_count", Name = "Count", UnsavedValueObject = 0, AccessType = typeof(int), TypeType = typeof(int))]
		public Int32 Count
		{
			get
			{
				return this._count;
			}
			set
			{
				this._count = value;
			}
		}

		/// <summary>
		/// Get/set for name
		/// </summary>
		[NHMA.Property(Column = "name_b", Generated = PropertyGeneration.Always)]
		public String Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		/// <summary>
		/// Get/set for Foo
		/// </summary>
		[NHMA.ManyToOne(0, Name = "Foo", Column = "F", Lazy = NHMA.Laziness.Proxy, Update = false, Insert = true, PropertyRef = "0", AccessType = typeof(int), ClassType = typeof(Foo), Fetch = FetchMode.Join, OuterJoin = NHMA.OuterJoinStrategy.True)]
		public Foo Foo
		{
			get
			{
				return this._foo;
			}
			set
			{
				this._foo = value;
			}
		}

		/// <summary>
		/// Get/set for stringList
		/// </summary>
		[NHMA.List(0, Table = "string_list", BatchSize = 7, Check = "Check", AccessType = typeof(int), PersisterType = typeof(Foo))]
		[NHMA.Key(1)]
		[NHMA.Column(2, Name = "id", Length = 16)]
		[NHMA.Index(3, Column = "`i`")]
		[NHMA.Element(4, Column = "element", TypeType = typeof(Baz.NestedBaz))]
		public System.Collections.Generic.IList<Baz> StringList
		{
			get
			{
				return this._stringList;
			}
			set
			{
				this._stringList = value;
			}
		}

		/// <summary>
		/// Get/set for fees
		/// </summary>
		[NHMA.List(0, Lazy = NHMA.CollectionLazy.True, Cascade = "all", Name = "List", AccessType = typeof(Foo), OuterJoin = NHMA.OuterJoinStrategy.True)]
		[NHMA.Key(1, Column = "bazid")]
		[NHMA.ListIndex(2, Column = "bazind", Base = 123)]
		[NHMA.Column(3, Name = "listIndexCol", Length = 4)]
		[NHMA.OneToMany(4, NotFound = NHMA.NotFoundMode.Exception, ClassType = typeof(Fee), EntityNameType = typeof(Fee))]
		public System.Collections.Generic.IList<Fee> Fees
		{
			get { return _fees; }
			set { _fees = value; }
		}

		/// <summary>
		/// Get/set for customs
		/// </summary>
		[NHMA.List(OptimisticLock = true)]
		[NHMA.Key(1, Column = "id_")]
		[NHMA.Index(2, Column = "indx")]
		[NHMA.Element(3, TypeType = typeof(double))]
		[NHMA.Column(4, Name = "first_", Scale = 0)]
		[NHMA.Column(5, Name = "second_", Scale = 1)]
		public System.Collections.Generic.IList<double> Customs
		{
			get
			{
				return this._customs;
			}
			set
			{
				this._customs = value;
			}
		}

		/// <summary>
		/// Get/set for topComponents
		/// </summary>
		[NHMA.List(0, Table = "topcomponents", Schema = "Schema", Where = "0", Inverse = false, Fetch = CollectionFetchMode.Select, PersisterType = typeof(int))]
		[NHMA.Cache(1, Region = "kmer", Usage = NHMA.CacheUsage.ReadWrite, Include = CacheInclude.All)]
		[NHMA.Key(2, Column = "id_")]
		[NHMA.Index(3, Column = "i")]
		[NHMA.CompositeElement(4, ClassType = typeof(FooComponent))]
		[NHMA.Property(5, Name = "Name")]
		[NHMA.Property(6, Name = "Count", Column = "count_", TypeType = typeof(int))]
		public System.Collections.Generic.IList<FooComponent> TopComponents
		{
			get
			{
				return this._topComponents;
			}
			set
			{
				this._topComponents = value;
			}
		}

		/// <summary>
		/// Get/set for fooToGlarch
		/// </summary>
		[NHMA.Map(0)]
		[NHMA.Key(1)]
		[NHMA.Column(2, Name = "baz_id", Length = 16)]
		[NHMA.IndexManyToMany(3, Column = "foo_id", ClassType = typeof(Foo))]
		[NHMA.ManyToMany(4, Column = "glarch_id", ClassType = typeof(Glarch), Lazy = NHMA.RestrictedLaziness.Proxy, Where = "0==0", OuterJoin = NHMA.OuterJoinStrategy.Auto)]
		[NHMA.Formula(5, Content = "Formula E=MC2")]
		public System.Collections.Generic.IDictionary<Foo, Glarch> FooToGlarch
		{
			get
			{
				return this._fooToGlarch;
			}
			set
			{
				this._fooToGlarch = value;
			}
		}

		/// <summary>
		/// Get/set for fooComponentToFoo
		/// </summary>
		[NHMA.Map(OptimisticLock = true)]
		[NHMA.Cache(1, Region = "togs", Usage = NHMA.CacheUsage.ReadWrite)]
		[NHMA.Key(2)]
		[NHMA.Column(3, Name = "baz_id", Length = 16)]
		[NHMA.CompositeIndex(4, ClassType = typeof(FooComponent))]
		[NHMA.KeyProperty(5, Name = "Name", Length = 32, Access = "field.camelcase-underscore")]
		[NHMA.KeyProperty(6, Name = "Count", Column = "count_", AccessType = typeof(Foo), TypeType = typeof(int))]
		[NHMA.ManyToMany(7, Column = "foo_id", ClassType = typeof(Foo), EntityNameType = typeof(Foo), OuterJoin = NHMA.OuterJoinStrategy.True)]
		public System.Collections.Generic.IDictionary<FooComponent, Foo> FooComponentToFoo
		{
			get
			{
				return this._fooComponentToFoo;
			}
			set
			{
				this._fooComponentToFoo = value;
			}
		}

		/// <summary>
		/// Get/set for glarchToFoo
		/// </summary>
		[NHMA.Map(Name = "GTF", AccessType = typeof(int), Schema = "Schema", Inverse = false, Fetch = CollectionFetchMode.Subselect, PersisterType = typeof(Foo))]
		[NHMA.Key(1)]
		[NHMA.Column(2, Name = "gtf_baz_id", Length = 16)]
		[NHMA.IndexManyToMany(3, Column = "gtf_foo_id", ClassType = typeof(string), ForeignKey = "FK")]
		[NHMA.OneToMany(4, ClassType = typeof(Glarch))]
		public System.Collections.Generic.IDictionary<string, Glarch> GlarchToFoo
		{
			get
			{
				return this._glarchToFoo;
			}
			set
			{
				this._glarchToFoo = value;
			}
		}

		/// <summary>
		/// Get/set for stringDateMap
		/// </summary>
		[NHMA.Map(-3, Lazy = NHMA.CollectionLazy.True, SortType = typeof(ReverseComparator), AccessType = typeof(Foo), PersisterType = typeof(int))]
		[NHMA.Key(-2, Column = "id_")]
		[NHMA.Index(-1, Column = "map_key", TypeType = typeof(Foo), Length = 32)]
		[NHMA.Element(Column = "map_value", TypeType = typeof(System.DateTime), Length = 9, Unique = false)]
		public System.Collections.Generic.IDictionary<Foo, DateTime> StringDateMap
		{
			get
			{
				return this._stringDateMap;
			}
			set
			{
				this._stringDateMap = value;
			}
		}

		/// <summary>
		/// Get/set for topGlarchez
		/// </summary>
		[NHMA.Map(BatchSize = 9, Check = "0", OrderBy = "1", SortType = typeof(int))]
		[NHMA.Key(1, Column = "idtopglarch")]
		[NHMA.Index(2, Column = "mapkey", TypeType = typeof(char), Length = 1)]
		[NHMA.OneToMany(3, ClassType = typeof(Glarch))]
		public System.Collections.Generic.IDictionary<char, Glarch> TopGlarchez
		{
			get
			{
				return this._topGlarchez;
			}
			set
			{
				this._topGlarchez = value;
			}
		}

		/// <summary>
		/// Get/set for cachedMap
		/// </summary>
		[NHMA.Map(0, Sort = "natural", Table = "cached_map")]
		[NHMA.Cache(1, Usage = NHMA.CacheUsage.ReadWrite)]
		[NHMA.Key(2, Column = "baz")]
		[NHMA.IndexManyToMany(3, Column = "another_baz", ClassType = typeof(Baz))]
		[NHMA.CompositeElement(4, ClassType = typeof(FooComponent))]
		[NHMA.Property(5, Name = "Foo")]
		[NHMA.Property(6, Name = "Bar")]
		public System.Collections.Generic.IDictionary<Baz, FooComponent> CachedMap
		{
			get
			{
				return this._cachedMap;
			}
			set
			{
				this._cachedMap = value;
			}
		}

		/// <summary>
		/// Get/set for stringGlarchMap
		/// </summary>
		[NHMA.Map(0, Where = "baz_map_index &gt; 'a' and tha_key is not null", Cascade = "all")]
		[NHMA.Cache(1, Usage = NHMA.CacheUsage.ReadWrite)]
		[NHMA.Key(2, Column = "baz")]
		[NHMA.IndexManyToMany(3, Column = "another_baz", ClassType = typeof(Baz))]
		[NHMA.CompositeElement(4, ClassType = typeof(FooComponent))]
		[NHMA.Property(5, Name = "Foo")]
		[NHMA.Property(6, Name = "Bar")]
		public System.Collections.Generic.IDictionary<Baz, FooComponent> StringGlarchMap
		{
			get
			{
				return this._stringGlarchMap;
			}
			set
			{
				this._stringGlarchMap = value;
			}
		}

		/// <summary>
		/// Get/set for anyToAny
		/// </summary>
		[NHMA.Map(-5, Lazy = NHMA.CollectionLazy.True)]
		[NHMA.Key(-4, Column = "baz")]
		[NHMA.IndexManyToAny(-3, IdTypeType = typeof(System.Int64), MetaTypeType = typeof(int))]
		[NHMA.Column(-2, Name = "ind_id_")]
		[NHMA.ManyToAny(-1, IdTypeType = typeof(System.Int64), MetaTypeType = typeof(Baz.NestingComponent))]
		[NHMA.MetaValue(Value = "meta-value", ClassType = typeof(Guid))]
		[NHMA.Column(1, Name = "el_clazz_")]
		public System.Collections.Generic.IDictionary<Int64, NestingComponent> AnyToAny
		{
			get
			{
				return this._anyToAny;
			}
			set
			{
				this._anyToAny = value;
			}
		}

		/// <summary>
		/// Get/set for manyToAny
		/// </summary>
		[NHMA.List(0, Lazy = NHMA.CollectionLazy.True, CollectionTypeType = typeof(System.Collections.ArrayList))]
		[NHMA.Key(1, Column = "baz")]
		[NHMA.Index(2, Column = "ind")]
		[NHMA.ManyToAny(3, IdTypeType = typeof(string))]
		[NHMA.Column(4, Name = "el_clazz_")]
		[NHMA.Column(5, Name = "el_id_")]
		public System.Collections.Generic.IList<object> ManyToAny
		{
			get
			{
				return this._manyToAny;
			}
			set
			{
				this._manyToAny = value;
			}
		}

		/// <summary>
		/// Gets or sets the intArray
		/// </summary>
		[NHMA.PrimitiveArray(0, Table = "int_array", AccessType = typeof(int), Schema = "Schema", Where = "0")]
		[NHMA.Key(1)]
		[NHMA.Column(2, Name = "id", Length = 16)]
		[NHMA.Index(3, Column = "i")]
		[NHMA.Element(4, Column = "j", TypeType = typeof(int))]
		public int[] IntArray
		{
			get
			{
				return _intArray;
			}
			set
			{
				_intArray = value;
			}
		}

		/// <summary>
		/// Gets or sets the _components
		/// </summary> 
		[NHMA.Array(0, Table = "bazcomponents", Access = "unknow")]
		[NHMA.Key(1)]
		[NHMA.Column(2, Name = "baz_id", Length = 16)]
		[NHMA.Index(3, Column = "i")]
		[NHMA.CompositeElement(4, ClassType = typeof(FooComponent))]
		[NHMA.Parent(5, Name = "Baz")]
		[NHMA.Property(6, Name = "Name")]
		[NHMA.Column(7, Name = "name", Length = 56)]
		[NHMA.Property(8, Name = "Count", Column = "count_", TypeType = typeof(int))]
		[NHMA.NestedCompositeElement(9, Name = "Subcomponent", ClassType = typeof(int), AccessType = typeof(Foo))]
		[NHMA.Property(10, Name = "Name", Column = "x_", AccessType = typeof(int))]
		[NHMA.Property(11, Name = "Count", Column = "y_", TypeType = typeof(Baz), AccessType = typeof(Baz))]
		public FooComponent[] Components
		{
			get
			{
				return _components;
			}
			set
			{
				_components = value;
			}
		}

		/// <summary>
		/// Gets or sets the timeArray
		/// </summary>
		[NHMA.Array(Name = "TimeArray", Schema = "Schema", ElementClass = "ElementClass", Cascade = "none", Where = "1=1")]
		[NHMA.Key(1)]
		[NHMA.Column(2, Name = "baz_id", Length = 16)]
		[NHMA.Index(3, Column = "j")]
		[NHMA.Element(4, Column = "the_time", TypeType = typeof(System.DateTime))]
		public DateTime[] TimeArray
		{
			get
			{
				return _timeArray;
			}
			set
			{
				_timeArray = value;
			}
		}

		/// <summary>
		/// Gets or sets the stringArray
		/// </summary>
		[NHMA.Any(Name = "StringArray", Insert = true, Update = true, Node = "node", Index = "null", IdTypeType = typeof(Foo), AccessType = typeof(Baz), MetaTypeType = typeof(int))]
		[NHMA.MetaValue(1, Value = "val2", ClassType = typeof(int))]
		[NHMA.Column(2, Name = "clazz")]
		public string[] StringArray
		{
			get
			{
				return _stringArray;
			}
			set
			{
				_stringArray = value;
			}
		}


		/// <summary>
		/// Gets or sets the fooArray
		/// </summary> 
		public IFooProxy[] FooArray
		{
			get
			{
				return _fooArray;
			}
			set
			{
				_fooArray = value;
			}
		}



		/// <summary>
		/// Get/set for fooSet
		/// </summary>
		public System.Collections.Generic.ISet<Foo> FooSet
		{
			get
			{
				return this._fooSet;
			}
			set
			{
				this._fooSet = value;
			}
		}

		/// <summary>
		/// Get/set for stringSet
		/// </summary>
		public System.Collections.Generic.ISet<string> StringSet
		{
			get
			{
				return this._stringSet;
			}
			set
			{
				this._stringSet = value;
			}
		}

		/// <summary>
		/// Get/set for topFoos
		/// </summary>
		public System.Collections.Generic.ISet<Foo> TopFoos
		{
			get
			{
				return this._topFoos;
			}
			set
			{
				this._topFoos = value;
			}
		}

		/// <summary>
		/// Get/set for cascadingBars
		/// </summary>
		public System.Collections.Generic.ISet<Bar> CascadingBars
		{
			get
			{
				return this._cascadingBars;
			}
			set
			{
				this._cascadingBars = value;
			}
		}

		/// <summary>
		/// Get/set for cached
		/// </summary>
		public System.Collections.Generic.ISet<object> Cached
		{
			get
			{
				return this._cached;
			}
			set
			{
				this._cached = value;
			}
		}

		/// <summary>
		/// Get/set for sortablez
		/// </summary>
		public System.Collections.Generic.ISet<object> Sortablez
		{
			get
			{
				return this._sortablez;
			}
			set
			{
				this._sortablez = value;
			}
		}

		/// <summary>
		/// Get/set for bag
		/// </summary>
		[NHMA.Bag(-2, Name = "Bag", OptimisticLock = true, OrderBy = "x", Where = "1", Lazy = NHMA.CollectionLazy.True, Check = "0", AccessType = typeof(Foo), PersisterType = typeof(string), Cascade = "all")]
		[NHMA.Key(-1, Column = "baz")]
		[NHMA.Column(Name = "`baz_id@#$`", NotNull = true, Unique = false, UniqueKey = "1")]
		[NHMA.Element(1, Column = "`name!`", TypeType = typeof(string))]
		public System.Collections.Generic.IList<string> Bag
		{
			get
			{
				return this._bag;
			}
			set
			{
				this._bag = value;
			}
		}

		/// <summary>
		/// Get/set for fooBag
		/// </summary>
		[NHMA.Bag(Name = "Bag", AccessType = typeof(int), Schema = "Schema", Inverse = false, BatchSize = 9, PersisterType = typeof(Foo), OuterJoin = NHMA.OuterJoinStrategy.True)]
		[NHMA.Key(1, ForeignKey = "baz")]
		[NHMA.Column(2, Name = "`baz_id@#$`", SqlType = "0", Index = "0", Check = "1")]
		[NHMA.Element(3, Column = "`name!`", TypeType = typeof(string))]
		public System.Collections.Generic.IList<string> FooBag
		{
			get
			{
				return this._fooBag;
			}
			set
			{
				this._fooBag = value;
			}
		}

		/// <summary>
		/// Get/set for bazez
		/// </summary>
		[NHMA.Set(Name = "Bazez", AccessType = typeof(Foo), Table = "SetTable", Schema = "Schema", Lazy = NHMA.CollectionLazy.Extra, Check = "0", OrderBy = "1", BatchSize = 3, Fetch = CollectionFetchMode.Join, PersisterType = typeof(int), SortType = typeof(Foo))]
		[NHMA.Key(1, Column = "col")]
		[NHMA.OneToMany(2, ClassType = typeof(int))]
		public System.Collections.Generic.IList<int> Bazez
		{
			get
			{
				return this._bazez;
			}
			set
			{
				this._bazez = value;
			}
		}

		/// <summary>
		/// Get/set for idFooBag
		/// </summary>
		[NHMA.IdBag(0, Name = "IdFooBag", Lazy = NHMA.CollectionLazy.False, CollectionTypeType = typeof(bool), Table = "baz_id_foo", Cascade = "all", AccessType = typeof(int), Schema = "null", OrderBy = "1", Where = "1")]
		[NHMA.CollectionId(1, Column = "pkid", TypeType = typeof(System.Int64), Length = 8)]
		[NHMA.Generator(2, Class = "hilo")]
		[NHMA.Key(3, Column = "baz")]
		[NHMA.ManyToMany(4, NotFound = NHMA.NotFoundMode.Exception, ClassType = typeof(Foo), Column = "the_time", Fetch = FetchMode.Select, OuterJoin = NHMA.OuterJoinStrategy.False)]
		public System.Collections.Generic.IList<Foo> IdFooBag
		{
			get
			{
				return this._idFooBag;
			}
			set
			{
				this._idFooBag = value;
			}
		}

		/// <summary>
		/// Get/set for byteBag
		/// </summary>
		[NHMA.IdBag(0, Lazy = NHMA.CollectionLazy.True, Inverse = true, Table = "baz_byte_bag", Cascade = "all", OptimisticLock = true)]
		[NHMA.CollectionId(1, Column = "pkid", TypeType = typeof(System.Int64))]
		[NHMA.Generator(2, Class = "hilo")]
		[NHMA.Key(3, Column = "baz")]
		[NHMA.Element(4, TypeType = typeof(byte[]), Column = "bytez", NotNull = true)]
		public System.Collections.Generic.IList<byte[]> ByteBag
		{
			get
			{
				return this._byteBag;
			}
			set
			{
				this._byteBag = value;
			}
		}

		#endregion
	}


	#region Shared components Address & CompAddress
	public class Address
	{
		[NHMA.Property]
		public string Name
		{
			get { return null; }
			set { }
		}

		[NHMA.Property(Column = "{{City.Column}}")]
		[NHMA.AttributeIdentifierAttribute("City.Column", ValueFormat = "x", ValueObject = System.DayOfWeek.Wednesday)] // Default value
		public string City
		{
			get { return null; }
			set { }
		}
	}

	[NHMA.Component]
	public class CompAddress
	{
		[NHMA.Property]
		public string FullName
		{
			get { return null; }
			set { }
		}

		[NHMA.Property]
		public string POBox
		{
			get { return null; }
			set { }
		}
	}
	#endregion


	#region class JoinedBaz
	[NHMA.JoinedSubclass(NameType = typeof(JoinedBaz), ProxyType = typeof(JoinedBaz), ExtendsType = typeof(Baz), SelectBeforeUpdate = true, SchemaAction = "X")]
	[NHMA.Key(Column = "JoinedId")]
	internal class JoinedBaz : Baz
	{
		private IFooProxy _reverse;
		private object _object;

		[NHMA.OneToOne(1, Name = "Reverse", ClassType = typeof(IFooProxy), Lazy = NHMA.Laziness.False, AccessType = typeof(Foo), ForeignKey = "FK", Fetch = FetchMode.Join, Cascade = "save-update")]
		[NHMA.Meta(2, Attribute = "OneToOne Meta", Inherit = false)]
		[NHMA.OneToOne(3, ClassType = typeof(int), Lazy = NHMA.Laziness.Proxy, AccessType = typeof(int), PropertyRef = "TWO", OuterJoin = NHMA.OuterJoinStrategy.Auto, Constrained = true)]
		[NHMA.Meta(4, Attribute = "OneToOne Meta TWO")]
		public virtual IFooProxy Reverse
		{
			get { return _reverse; }
			set { _reverse = value; }
		}


		[NHMA.Meta(-2, Attribute = "Meta", Content = "Content")]
		[NHMA.Any(-1, IdTypeType = typeof(System.Int64), Cascade = "all", AccessType = typeof(int), MetaTypeType = typeof(Baz))]
		[NHMA.MetaValue(Value = "val1", ClassType = typeof(Foo))]
		[NHMA.Column(1, Name = "clazz", Length = 200)]
		public object Object
		{
			get { return _object; }
			set { _object = value; }
		}


		[NHMA.Component(Name = "MyAddress")]
		protected class SubAddress : Address { }

		public Address MyAddress
		{
			get { return null; }
			set { }
		}

		[NHMA.ComponentProperty] // Auto-detection :)
		public CompAddress MyAutoCompAddress
		{
			get { return null; }
			set { }
		}

		[NHMA.DynamicComponent]
		[NHMA.Property(1, Name = "DynProp")]
		public string MyDynCompAddress2
		{
			get { return null; }
			set { }
		}

		[NHMA.Loader(QueryRef = "ref")]
		[NHMA.SqlInsert(1, Content = "INSERT")]
		[NHMA.SqlUpdate(2, Content = "UPDATE")]
		[NHMA.SqlDelete(3, Content = "DELETE")]
		public int sql = 2;
	}
	#endregion


	#region class Stuff
	[NHMA.Class(-1, NameType = typeof(int), Table = "Stuff", DiscriminatorValueEnumFormat = "none", DiscriminatorValueObject = 7, Schema = "none", Lazy = true, DynamicUpdate = false, DynamicInsert = false, SelectBeforeUpdate = true, OptimisticLock = NHMA.OptimisticLockMode.None, ProxyType = typeof(bool), PersisterType = typeof(string))]
	[NHMA.Cache(Usage = NHMA.CacheUsage.NonStrictReadWrite, Include = CacheInclude.NonLazy)]
	public class Stuff
	{
		[NHMA.Join(-1, Table = "Table", Schema = "Schema", Fetch = JoinFetch.Join, Inverse = true, Optional = false)]
		[NHMA.Comment(Content = "Comment on the Join")]
		[NHMA.Key(1, Column = "JoinedKey")]
		[NHMA.Property(2, Name = "JoinedProp")]
		[NHMA.ManyToOne(3, Name = "JoinedManyToOne")]
		private long _id;
		private Foo _foo;
		private DateTime _timestamp;
		private System.Collections.Generic.ISet<int> _set;


		[NHMA.Meta(Attribute = "ClassName", Content = "Stuff :)")]
		[NHMA.CompositeId(1, Name = "ID", ClassType = typeof(long), AccessType = typeof(int), UnsavedValue = NHMA.UnsavedValueType.Any)]
		[NHMA.KeyProperty(2, Name = "Id", AccessType = typeof(int), TypeType = typeof(Foo))]
		[NHMA.KeyManyToOne(3, Name = "Foo", ClassType = typeof(Foo), EntityNameType = typeof(Foo), Lazy = NHMA.RestrictedLaziness.False, AccessType = typeof(int), Column = "-", ForeignKey = "x")]
		[NHMA.KeyManyToOne(4, Name = "Bar", ClassType = typeof(int), EntityNameType = typeof(int), Lazy = NHMA.RestrictedLaziness.Proxy, AccessType = typeof(Bar), NotFound = NotFoundMode.Ignore)]
		public long Id
		{
			get { return _id; }
			set { _id = value; }
		}

		[NHMA.Property(-1, OptimisticLock = true, Generated = PropertyGeneration.Never)]
		[NHMA.Type(NameType = typeof(Foo))]
		[NHMA.Param(1, Name = "Property.Type", Content = "Param")]
		public Foo Foo
		{
			get { return _foo; }
			set { _foo = value; }
		}

		[NHMA.Timestamp(0, Source = TimestampSource.Vm, Generated = VersionGeneration.Always, Column = "`timestamp`", UnsavedValue = NHMA.TimestampUnsavedValue.Null, AccessType = typeof(bool))]
		public DateTime Timestamp
		{
			get { return _timestamp; }
			set { _timestamp = value; }
		}

		[NHMA.Set(-2, Generic = true, Inverse = true, OptimisticLock = true, CollectionTypeType = typeof(Stuff), Cascade = "all", OuterJoin = NHMA.OuterJoinStrategy.True, AccessType = typeof(bool), Where = "1=1", PersisterType = typeof(Foo), SortType = typeof(bool))]
		[NHMA.Key(-1, Column = "col")]
		[NHMA.OneToMany(ClassType = typeof(int))]
		public System.Collections.Generic.ISet<int> Set
		{
			get { return _set; }
			set { _set = value; }
		}

		[NHMA.Tuplizer(-1, ClassType = typeof(Baz), EntityMode = NHMA.TuplizerEntityMode.Poco)]
		[NHMA.Properties(Name = "Properties Property :)", Unique = true, Insert = false, Update = false, OptimisticLock = false, Node = "A node")]
		[NHMA.ManyToOne(1, Name = "Contained ManyToOne")]
		public System.Collections.Generic.ISet<int> Properties
		{
			get { return _set; }
			set { _set = value; }
		}


		[NHMA.Component(Name = "HomeAddress")]
		[NHMA.AttributeIdentifierAttribute("City.Column", Value = "HomeCity")]
		protected class HomeAddressMapping : Address { }

		public Address HomeAddress
		{
			get { return null; }
			set { }
		}

		[NHMA.Component(Name = "StuffAddress", ClassType = typeof(int), AccessType = typeof(Foo))]
		protected class SubAddress : Address { }

		public Address StuffAddress
		{
			get { return null; }
			set { }
		}

		[NHMA.ComponentProperty(ComponentType = typeof(CompAddress), PropertyName = "MyCompAddressTwo")]
		public string MyCompAddress2
		{
			get { return null; }
			set { }
		}
	}
	#endregion


	#region interface Sql
	[NHMA.Class(EntityName = "Entity Sql", Abstract = true)]
	[NHMA.Cache(Usage = NHMA.CacheUsage.NonStrictReadWrite)]
	[NHMA.Discriminator]
	public interface Sql
	{
		[NHMA.Id(-1)]
		[NHMA.Generator(Class = "?")]
		long id { get; }

		[NHMA.Loader(QueryRef = "ref")]
		[NHMA.SqlInsert(1, Check = CustomSqlCheck.None, Content = "INSERT INTO Table (Col1, Col2) VALUES ( UPPER(?), ? )")]
		[NHMA.SqlUpdate(2, Check = CustomSqlCheck.None, Content = "UPDATE Table SET Col1=UPPER(?) WHERE Id=?")]
		[NHMA.SqlDelete(3, Check = CustomSqlCheck.RowCount, Content = "DELETE FROM Table WHERE Id=?")]
		int sql { get; }

		[NHMA.Filter(Name = "Null", Condition = "1==2")]
		int filter { get; }
	}
	#endregion


	#region interface UnionSubclass
	[NHMA.UnionSubclass(Abstract = false, Table = "uT", Schema = "none", Check = "maybe", EntityNameType = typeof(Foo), ProxyType = typeof(UnionSubclass), ExtendsType = typeof(Baz), SelectBeforeUpdate = true)]
	public interface UnionSubclass
	{
		[NHMA.Meta(0, Attribute = "Meta", Content = "Content")]
		[NHMA.Tuplizer(1, Class = "FakeClass", EntityMode = NHMA.TuplizerEntityMode.Xml)]
		object Object { get; }
	}
	#endregion
}



#region Subclasses & JoinedSubclasses to test HbmSerializer.MapSubclasses() and classes nesting
/* Disabled because the original order (determined by the compiler) may vary and influence the final result

public class S
{
	[NHMA.Subclass(ExtendsType=typeof(Sub_Sub_SubA_1))]
	private class Sub_Sub_Sub_SubA_1 : Sub_Sub_SubA_1 {}
	[NHMA.Subclass(ExtendsType=typeof(SubA_1))]
	private class Sub_SubA_1 : SubA_1 {}
	[NHMA.Subclass(ExtendsType=typeof(SubA_2))]
	private class Sub_Sub_A_2 : SubA_2 {}
	[NHMA.Subclass(ExtendsType=typeof(Sub_SubA_1))]
	private class Sub_Sub_SubA_1 : Sub_SubA_1 {}
	[NHMA.Subclass(ExtendsType=typeof(A))]
	private class SubA_2 : A {}
	[NHMA.Subclass(ExtendsType=typeof(A))]
	private class SubA_1 : A {}
	[NHMA.Subclass(ExtendsType=typeof(Guid))]
	private class A {}
}

class JS
{
	[NHMA.JoinedSubclass(ExtendsType=typeof(Sub_Sub_SubA_1))]
	private class Sub_Sub_Sub_SubA_1 : Sub_Sub_SubA_1 {}
	[NHMA.JoinedSubclass(ExtendsType=typeof(SubA_1))]
	private class Sub_SubA_1 : SubA_1 {}
	[NHMA.JoinedSubclass(ExtendsType=typeof(SubA_2))]
	internal class Sub_Sub_A_2 : SubA_2 {}
	[NHMA.JoinedSubclass(ExtendsType=typeof(Sub_SubA_1))]
	private class Sub_Sub_SubA_1 : Sub_SubA_1 {}
	[NHMA.JoinedSubclass(ExtendsType=typeof(A))]
	internal class SubA_2 : A {}
	[NHMA.JoinedSubclass(ExtendsType=typeof(A))]
	private class SubA_1 : A {}
	[NHMA.JoinedSubclass(ExtendsType=typeof(Guid))]
	internal class A {}
}/**/


// Test mapping of nested classes
internal class X
{
	[NHMA.Subclass(ExtendsType = typeof(Guid))]
	private class PrivS
	{
		[NHMA.Class]
		private class PrivC
		{
			[NHMA.Subclass(NameType = typeof(IntS), ExtendsType = typeof(Guid))]
			internal class IntS : PrivS
			{
				[NHMA.Component(Name = "CompX")]
				private class Comp { }

				[NHMA.Class(NameType = typeof(IntC))]
				internal class IntC : PrivC
				{
					[NHMA.Id]
					[NHMA.Generator(1, Class = "")]
					[NHMA.RawXml(After = typeof(NHMA.IdAttribute), Content = @"<version name="""" />")]
					public int _id = -1;
				}
			}

			[NHMA.RawXml(Content = @"
    <id>
      <generator class="""" />
    </id>")]
			public int id = -1;
		}

		[NHMA.JoinedSubclass(ExtendsType = typeof(Guid))]
		private class PrivJ
		{
			private class C
			{
				[NHMA.JoinedSubclass(NameType = typeof(IntJ), ExtendsType = typeof(Guid))]
				internal class IntJ : PrivJ
				{
					[NHMA.Key]
					public int _id = -1;
				}
			}
			[NHMA.Key(-1)]
			[NHMA.Property] // Test HbmWriter.Patterns
			public PrivC userPattern = new PrivC();

			[NHMA.Property] // Test HbmWriter.Patterns
			public System.Data.SqlTypes.SqlDateTime sqlPattern = new System.Data.SqlTypes.SqlDateTime();
		}
	}
}
/**/
#endregion

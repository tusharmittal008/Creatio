namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e5527da-8dee-45a8-b3e0-352e2950d2ab");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ce2ad255-5f67-4761-a910-9028518c0aa4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,81,107,219,48,16,126,31,244,63,28,166,15,54,4,209,190,174,91,97,201,210,82,40,219,168,157,189,140,61,40,242,197,213,144,37,163,147,211,101,99,255,125,39,203,89,82,167,131,30,54,182,78,223,125,247,125,199,129,149,45,82,39,21,66,133,222,75,114,155,32,22,206,110,116,211,123,25,180,179,103,111,224,55,191,28,61,105,219,64,185,163,128,237,213,113,234,184,178,109,157,253,239,165,71,177,180,65,7,141,244,26,140,88,110,209,134,61,244,219,144,222,13,185,123,205,34,44,250,188,84,143,216,202,79,108,2,222,67,182,34,255,128,210,132,93,86,124,79,69,93,191,54,90,129,50,146,8,210,221,11,52,240,22,230,146,240,133,155,196,50,14,224,136,208,109,89,178,174,17,182,78,215,240,217,150,114,203,70,114,183,254,129,42,0,161,173,209,207,32,17,206,113,195,174,6,218,15,190,33,192,226,64,119,196,28,99,205,42,196,63,182,61,13,22,87,207,97,137,23,252,224,135,141,231,41,81,164,130,9,184,70,165,91,105,160,243,90,197,41,165,42,113,139,161,218,117,88,47,156,233,91,251,85,154,30,223,141,208,235,60,78,242,75,196,175,202,143,217,180,187,222,64,158,200,174,225,242,98,31,197,115,208,196,88,12,20,119,180,144,86,161,193,154,117,4,223,35,51,159,226,40,248,184,20,188,151,36,27,172,176,237,140,12,81,185,197,39,184,119,74,26,253,75,174,13,150,3,46,31,253,172,8,61,47,174,229,249,243,214,138,7,36,215,123,197,32,231,153,101,6,167,125,98,28,86,38,237,90,54,131,236,164,5,137,97,60,119,84,57,55,215,77,58,101,133,168,220,40,161,120,133,15,214,159,18,226,198,249,86,134,124,226,143,27,95,138,139,249,249,201,184,99,132,71,239,158,6,255,203,159,10,187,232,112,95,63,133,255,57,28,199,95,254,240,243,23,198,197,44,16,234,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1cf0f422-f852-9faf-ea71-77c86bd9c1af"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("ce2ad255-5f67-4761-a910-9028518c0aa4"),
				CreatedInSchemaUId = new Guid("1e5527da-8dee-45a8-b3e0-352e2950d2ab"),
				ModifiedInSchemaUId = new Guid("1e5527da-8dee-45a8-b3e0-352e2950d2ab")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e5527da-8dee-45a8-b3e0-352e2950d2ab"));
		}

		#endregion

	}

	#endregion

}


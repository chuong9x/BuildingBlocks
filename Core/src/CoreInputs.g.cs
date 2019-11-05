// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Core
{
	public class CoreInputs: S3Args
	{
		/// <summary>
		/// Core plan length.
		/// </summary>
		[JsonProperty("Length")]
		public double Length {get;}

		/// <summary>
		/// Core plan width.
		/// </summary>
		[JsonProperty("Width")]
		public double Width {get;}

		/// <summary>
		/// Offset from the height of the building envelope.
		/// </summary>
		[JsonProperty("Height Offset")]
		public double HeightOffset {get;}


		
		/// <summary>
		/// Construct a CoreInputs with default inputs.
		/// This should be used only for testing.
		/// </summary>
		public CoreInputs() : base()
		{
			this.Length = 10;
			this.Width = 10;
			this.HeightOffset = 3;

		}
		
		/// <summary>
		/// Construct a CoreInputs specifying all inputs.
		/// </summary>
		/// <returns></returns>
		[JsonConstructor]
		public CoreInputs(double length, double width, double heightoffset, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
		{
			this.Length = length;
			this.Width = width;
			this.HeightOffset = heightoffset;

		}
	}
}
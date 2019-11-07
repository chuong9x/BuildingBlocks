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
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace FloorsByEnvelope
{
    public class FloorsByEnvelopeOutputs: ResultsBase
    {
		/// <summary>
		/// Floor area of all floors.
		/// </summary>
		[JsonProperty("Total Floor Area")]
		public double TotalFloorArea {get;}

		/// <summary>
		/// Count of the Envelopes in all the models.
		/// </summary>
		[JsonProperty("Envelope Count")]
		public double EnvelopeCount {get;}

		/// <summary>
		/// Count of the Elements in all the models.
		/// </summary>
		[JsonProperty("Element Count")]
		public double ElementCount {get;}


        
        /// <summary>
        /// Construct a FloorsByEnvelopeOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public FloorsByEnvelopeOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a FloorsByEnvelopeOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public FloorsByEnvelopeOutputs(double totalfloorarea, double envelopecount, double elementcount): base()
        {
			this.TotalFloorArea = totalfloorarea;
			this.EnvelopeCount = envelopecount;
			this.ElementCount = elementcount;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}
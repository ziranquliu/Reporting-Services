using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.PBIRS.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SharedDataSets {
    /// <summary>
    /// Gets or Sets DataSets
    /// </summary>
    [DataMember(Name="DataSets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DataSets")]
    public List<SharedDataSetPath> DataSets { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SharedDataSets {\n");
      sb.Append("  DataSets: ").Append(DataSets).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}

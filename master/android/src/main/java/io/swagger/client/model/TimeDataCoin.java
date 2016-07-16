package io.swagger.client.model;


import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;


@ApiModel(description = "")
public class TimeDataCoin  {
  
  @SerializedName("time")
  private Long time = null;
  @SerializedName("verifiedTime")
  private Long verifiedTime = null;

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public Long getTime() {
    return time;
  }
  public void setTime(Long time) {
    this.time = time;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public Long getVerifiedTime() {
    return verifiedTime;
  }
  public void setVerifiedTime(Long verifiedTime) {
    this.verifiedTime = verifiedTime;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TimeDataCoin timeDataCoin = (TimeDataCoin) o;
    return (time == null ? timeDataCoin.time == null : time.equals(timeDataCoin.time)) &&
        (verifiedTime == null ? timeDataCoin.verifiedTime == null : verifiedTime.equals(timeDataCoin.verifiedTime));
  }

  @Override
  public int hashCode() {
    int result = 17;
    result = 31 * result + (time == null ? 0: time.hashCode());
    result = 31 * result + (verifiedTime == null ? 0: verifiedTime.hashCode());
    return result;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class TimeDataCoin {\n");
    
    sb.append("  time: ").append(time).append("\n");
    sb.append("  verifiedTime: ").append(verifiedTime).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
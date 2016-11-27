/*
 * Coinsecure Api Documentation
 * To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.
 *
 * OpenAPI spec version: beta
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


package io.swagger.client.model;

import java.util.Objects;
import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * RateVolTimeTypeData
 */
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-27T22:11:57.435Z")
public class RateVolTimeTypeData {
  @SerializedName("time")
  private Long time = null;

  @SerializedName("rate")
  private Long rate = null;

  @SerializedName("vol")
  private Long vol = null;

  @SerializedName("ordType")
  private String ordType = null;

  public RateVolTimeTypeData time(Long time) {
    this.time = time;
    return this;
  }

   /**
   * Get time
   * @return time
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public Long getTime() {
    return time;
  }

  public void setTime(Long time) {
    this.time = time;
  }

  public RateVolTimeTypeData rate(Long rate) {
    this.rate = rate;
    return this;
  }

   /**
   * Get rate
   * @return rate
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public Long getRate() {
    return rate;
  }

  public void setRate(Long rate) {
    this.rate = rate;
  }

  public RateVolTimeTypeData vol(Long vol) {
    this.vol = vol;
    return this;
  }

   /**
   * Get vol
   * @return vol
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public Long getVol() {
    return vol;
  }

  public void setVol(Long vol) {
    this.vol = vol;
  }

  public RateVolTimeTypeData ordType(String ordType) {
    this.ordType = ordType;
    return this;
  }

   /**
   * Get ordType
   * @return ordType
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public String getOrdType() {
    return ordType;
  }

  public void setOrdType(String ordType) {
    this.ordType = ordType;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RateVolTimeTypeData rateVolTimeTypeData = (RateVolTimeTypeData) o;
    return Objects.equals(this.time, rateVolTimeTypeData.time) &&
        Objects.equals(this.rate, rateVolTimeTypeData.rate) &&
        Objects.equals(this.vol, rateVolTimeTypeData.vol) &&
        Objects.equals(this.ordType, rateVolTimeTypeData.ordType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(time, rate, vol, ordType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RateVolTimeTypeData {\n");
    
    sb.append("    time: ").append(toIndentedString(time)).append("\n");
    sb.append("    rate: ").append(toIndentedString(rate)).append("\n");
    sb.append("    vol: ").append(toIndentedString(vol)).append("\n");
    sb.append("    ordType: ").append(toIndentedString(ordType)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

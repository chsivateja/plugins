package io.swagger.client.model;

import io.swagger.client.model.TimeDataCoin;

import io.swagger.annotations.*;
import com.google.gson.annotations.SerializedName;


@ApiModel(description = "")
public class CoinDepData  {
  
  @SerializedName("timeDetails")
  private TimeDataCoin timeDetails = null;
  @SerializedName("address")
  private String address = null;
  @SerializedName("value")
  private Long value = null;
  @SerializedName("txHash")
  private String txHash = null;
  @SerializedName("depositID")
  private String depositID = null;
  @SerializedName("reason")
  private String reason = null;

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public TimeDataCoin getTimeDetails() {
    return timeDetails;
  }
  public void setTimeDetails(TimeDataCoin timeDetails) {
    this.timeDetails = timeDetails;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public String getAddress() {
    return address;
  }
  public void setAddress(String address) {
    this.address = address;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public Long getValue() {
    return value;
  }
  public void setValue(Long value) {
    this.value = value;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public String getTxHash() {
    return txHash;
  }
  public void setTxHash(String txHash) {
    this.txHash = txHash;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public String getDepositID() {
    return depositID;
  }
  public void setDepositID(String depositID) {
    this.depositID = depositID;
  }

  /**
   **/
  @ApiModelProperty(required = true, value = "")
  public String getReason() {
    return reason;
  }
  public void setReason(String reason) {
    this.reason = reason;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CoinDepData coinDepData = (CoinDepData) o;
    return (timeDetails == null ? coinDepData.timeDetails == null : timeDetails.equals(coinDepData.timeDetails)) &&
        (address == null ? coinDepData.address == null : address.equals(coinDepData.address)) &&
        (value == null ? coinDepData.value == null : value.equals(coinDepData.value)) &&
        (txHash == null ? coinDepData.txHash == null : txHash.equals(coinDepData.txHash)) &&
        (depositID == null ? coinDepData.depositID == null : depositID.equals(coinDepData.depositID)) &&
        (reason == null ? coinDepData.reason == null : reason.equals(coinDepData.reason));
  }

  @Override
  public int hashCode() {
    int result = 17;
    result = 31 * result + (timeDetails == null ? 0: timeDetails.hashCode());
    result = 31 * result + (address == null ? 0: address.hashCode());
    result = 31 * result + (value == null ? 0: value.hashCode());
    result = 31 * result + (txHash == null ? 0: txHash.hashCode());
    result = 31 * result + (depositID == null ? 0: depositID.hashCode());
    result = 31 * result + (reason == null ? 0: reason.hashCode());
    return result;
  }

  @Override
  public String toString()  {
    StringBuilder sb = new StringBuilder();
    sb.append("class CoinDepData {\n");
    
    sb.append("  timeDetails: ").append(timeDetails).append("\n");
    sb.append("  address: ").append(address).append("\n");
    sb.append("  value: ").append(value).append("\n");
    sb.append("  txHash: ").append(txHash).append("\n");
    sb.append("  depositID: ").append(depositID).append("\n");
    sb.append("  reason: ").append(reason).append("\n");
    sb.append("}\n");
    return sb.toString();
  }
}
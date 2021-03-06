//
// BlockchainToolsAPI.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Alamofire



public class BlockchainToolsAPI: APIBase {
    /**
     Search Bitcoin Blockchain
     
     - parameter any: (path)  
     - parameter completion: completion handler to receive the data and the error objects
     */
    public class func v1bitcoinsearchAddress(any any: String, completion: ((data: ValidAddressSearchDataResponse?, error: ErrorType?) -> Void)) {
        v1bitcoinsearchAddressWithRequestBuilder(any: any).execute { (response, error) -> Void in
            completion(data: response?.body, error: error);
        }
    }


    /**
     Search Bitcoin Blockchain
     - GET /v1/bitcoin/search/{any}
     - Searches for a Bitcoin Address, Netki Wallet Name or Transaction ID.
     - examples: [{contentType=application/json, example={
  "method" : "aeiou",
  "success" : true,
  "time" : "2000-01-23T04:56:07.000+00:00",
  "message" : {
    "unconfirmedBalance" : 123456789,
    "address" : "aeiou",
    "balance" : 123456789,
    "unconfirmedTxApperances" : 123,
    "totalReceived" : 123456789,
    "transactions" : [ "aeiou" ],
    "txApperances" : 123
  },
  "title" : "aeiou"
}}, {contentType=application/xml, example=<null>
  <success>true</success>
  <method>string</method>
  <title>string</title>
  <time>2000-01-23T04:56:07.000Z</time>
</null>}]
     - examples: [{contentType=application/json, example={
  "method" : "aeiou",
  "success" : true,
  "time" : "2000-01-23T04:56:07.000+00:00",
  "message" : {
    "unconfirmedBalance" : 123456789,
    "address" : "aeiou",
    "balance" : 123456789,
    "unconfirmedTxApperances" : 123,
    "totalReceived" : 123456789,
    "transactions" : [ "aeiou" ],
    "txApperances" : 123
  },
  "title" : "aeiou"
}}, {contentType=application/xml, example=<null>
  <success>true</success>
  <method>string</method>
  <title>string</title>
  <time>2000-01-23T04:56:07.000Z</time>
</null>}]
     
     - parameter any: (path)  

     - returns: RequestBuilder<ValidAddressSearchDataResponse> 
     */
    public class func v1bitcoinsearchAddressWithRequestBuilder(any any: String) -> RequestBuilder<ValidAddressSearchDataResponse> {
        var path = "/v1/bitcoin/search/{any}"
        path = path.stringByReplacingOccurrencesOfString("{any}", withString: "\(any)", options: .LiteralSearch, range: nil)
        let URLString = SwaggerClientAPI.basePath + path

        let nillableParameters: [String:AnyObject?] = [:]
 
        let parameters = APIHelper.rejectNil(nillableParameters)
 
        let convertedParameters = APIHelper.convertBoolToString(parameters)
 
        let requestBuilder: RequestBuilder<ValidAddressSearchDataResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

        return requestBuilder.init(method: "GET", URLString: URLString, parameters: convertedParameters, isBody: true)
    }

    /**
     Get Confirmations
     
     - parameter txid: (path)  
     - parameter completion: completion handler to receive the data and the error objects
     */
    public class func v1bitcoinsearchTxid(txid txid: String, completion: ((data: ConfirmDataResponse?, error: ErrorType?) -> Void)) {
        v1bitcoinsearchTxidWithRequestBuilder(txid: txid).execute { (response, error) -> Void in
            completion(data: response?.body, error: error);
        }
    }


    /**
     Get Confirmations
     - GET /v1/bitcoin/search/confirmation/{txid}
     - Searches for a Number of Confirmations on a transaction ID.
     - examples: [{contentType=application/json, example={
  "method" : "aeiou",
  "success" : true,
  "time" : "2000-01-23T04:56:07.000+00:00",
  "message" : {
    "confirmations" : 123456789
  },
  "title" : "aeiou"
}}, {contentType=application/xml, example=<null>
  <success>true</success>
  <method>string</method>
  <title>string</title>
  <time>2000-01-23T04:56:07.000Z</time>
</null>}]
     - examples: [{contentType=application/json, example={
  "method" : "aeiou",
  "success" : true,
  "time" : "2000-01-23T04:56:07.000+00:00",
  "message" : {
    "confirmations" : 123456789
  },
  "title" : "aeiou"
}}, {contentType=application/xml, example=<null>
  <success>true</success>
  <method>string</method>
  <title>string</title>
  <time>2000-01-23T04:56:07.000Z</time>
</null>}]
     
     - parameter txid: (path)  

     - returns: RequestBuilder<ConfirmDataResponse> 
     */
    public class func v1bitcoinsearchTxidWithRequestBuilder(txid txid: String) -> RequestBuilder<ConfirmDataResponse> {
        var path = "/v1/bitcoin/search/confirmation/{txid}"
        path = path.stringByReplacingOccurrencesOfString("{txid}", withString: "\(txid)", options: .LiteralSearch, range: nil)
        let URLString = SwaggerClientAPI.basePath + path

        let nillableParameters: [String:AnyObject?] = [:]
 
        let parameters = APIHelper.rejectNil(nillableParameters)
 
        let convertedParameters = APIHelper.convertBoolToString(parameters)
 
        let requestBuilder: RequestBuilder<ConfirmDataResponse>.Type = SwaggerClientAPI.requestBuilderFactory.getBuilder()

        return requestBuilder.init(method: "GET", URLString: URLString, parameters: convertedParameters, isBody: true)
    }

}

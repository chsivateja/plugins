//
// TradeAddressData.swift
//
// Generated by swagger-codegen
// https://github.com/swagger-api/swagger-codegen
//

import Foundation


public class TradeAddressData: JSONEncodable {
    public var address: String?
    public var time: Int64?
    public var info: String?
    public var netki: String?

    public init() {}

    // MARK: JSONEncodable
    func encodeToJSON() -> AnyObject {
        var nillableDictionary = [String:AnyObject?]()
        nillableDictionary["address"] = self.address
        nillableDictionary["time"] = self.time?.encodeToJSON()
        nillableDictionary["info"] = self.info
        nillableDictionary["netki"] = self.netki
        let dictionary: [String:AnyObject] = APIHelper.rejectNil(nillableDictionary) ?? [:]
        return dictionary
    }
}

<?php
/**
 * Merchant
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   http://github.com/swagger-api/swagger-codegen
 * @license  http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * coinMerchant Api Documentation
 *
 * To generate an API key, please visit <a href='https://pay.coinsecure.in/payment-tools/api' target='_new' class='homeapi'>https://pay.coinsecure.in/payment-tools/api</a>.<br>Guidelines for use can be accessed at <a href='https://pay.coinsecure.in/api/guidelines'>https://pay.coinsecure.in/api/guidelines</a>.
 *
 * OpenAPI spec version: 1.0B
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;

/**
 * Merchant Class Doc Comment
 *
 * @category    Class
 * @package     Swagger\Client
 * @author      http://github.com/swagger-api/swagger-codegen
 * @license     http://www.apache.org/licenses/LICENSE-2.0 Apache Licene v2
 * @link        https://github.com/swagger-api/swagger-codegen
 */
class Merchant implements ArrayAccess
{
    /**
      * The original name of the model.
      * @var string
      */
    protected static $swaggerModelName = 'Merchant';

    /**
      * Array of property to type mappings. Used for (de)serialization
      * @var string[]
      */
    protected static $swaggerTypes = array(
        'first_name' => 'string',
        'last_name' => 'string',
        'coin_balance' => 'int',
        'fiat_balance' => 'int',
        'merchant_type' => 'string',
        'organization' => 'string',
        'status' => 'string',
        'website' => 'string',
        'address' => 'string',
        'admin_email' => 'string',
        'business_type' => 'string',
        'info' => 'string',
        'min_coin_settlement' => 'int',
        'min_fiat_settlement' => 'int',
        'tel' => 'string'
    );

    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of attributes where the key is the local name, and the value is the original name
     * @var string[]
     */
    protected static $attributeMap = array(
        'first_name' => 'firstName',
        'last_name' => 'lastName',
        'coin_balance' => 'coinBalance',
        'fiat_balance' => 'fiatBalance',
        'merchant_type' => 'merchantType',
        'organization' => 'organization',
        'status' => 'status',
        'website' => 'website',
        'address' => 'address',
        'admin_email' => 'adminEmail',
        'business_type' => 'businessType',
        'info' => 'info',
        'min_coin_settlement' => 'minCoinSettlement',
        'min_fiat_settlement' => 'minFiatSettlement',
        'tel' => 'tel'
    );

    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     * @var string[]
     */
    protected static $setters = array(
        'first_name' => 'setFirstName',
        'last_name' => 'setLastName',
        'coin_balance' => 'setCoinBalance',
        'fiat_balance' => 'setFiatBalance',
        'merchant_type' => 'setMerchantType',
        'organization' => 'setOrganization',
        'status' => 'setStatus',
        'website' => 'setWebsite',
        'address' => 'setAddress',
        'admin_email' => 'setAdminEmail',
        'business_type' => 'setBusinessType',
        'info' => 'setInfo',
        'min_coin_settlement' => 'setMinCoinSettlement',
        'min_fiat_settlement' => 'setMinFiatSettlement',
        'tel' => 'setTel'
    );

    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     * @var string[]
     */
    protected static $getters = array(
        'first_name' => 'getFirstName',
        'last_name' => 'getLastName',
        'coin_balance' => 'getCoinBalance',
        'fiat_balance' => 'getFiatBalance',
        'merchant_type' => 'getMerchantType',
        'organization' => 'getOrganization',
        'status' => 'getStatus',
        'website' => 'getWebsite',
        'address' => 'getAddress',
        'admin_email' => 'getAdminEmail',
        'business_type' => 'getBusinessType',
        'info' => 'getInfo',
        'min_coin_settlement' => 'getMinCoinSettlement',
        'min_fiat_settlement' => 'getMinFiatSettlement',
        'tel' => 'getTel'
    );

    public static function getters()
    {
        return self::$getters;
    }

    

    

    /**
     * Associative array for storing property values
     * @var mixed[]
     */
    protected $container = array();

    /**
     * Constructor
     * @param mixed[] $data Associated array of property value initalizing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['first_name'] = isset($data['first_name']) ? $data['first_name'] : null;
        $this->container['last_name'] = isset($data['last_name']) ? $data['last_name'] : null;
        $this->container['coin_balance'] = isset($data['coin_balance']) ? $data['coin_balance'] : null;
        $this->container['fiat_balance'] = isset($data['fiat_balance']) ? $data['fiat_balance'] : null;
        $this->container['merchant_type'] = isset($data['merchant_type']) ? $data['merchant_type'] : null;
        $this->container['organization'] = isset($data['organization']) ? $data['organization'] : null;
        $this->container['status'] = isset($data['status']) ? $data['status'] : null;
        $this->container['website'] = isset($data['website']) ? $data['website'] : null;
        $this->container['address'] = isset($data['address']) ? $data['address'] : null;
        $this->container['admin_email'] = isset($data['admin_email']) ? $data['admin_email'] : null;
        $this->container['business_type'] = isset($data['business_type']) ? $data['business_type'] : null;
        $this->container['info'] = isset($data['info']) ? $data['info'] : null;
        $this->container['min_coin_settlement'] = isset($data['min_coin_settlement']) ? $data['min_coin_settlement'] : null;
        $this->container['min_fiat_settlement'] = isset($data['min_fiat_settlement']) ? $data['min_fiat_settlement'] : null;
        $this->container['tel'] = isset($data['tel']) ? $data['tel'] : null;
    }

    /**
     * show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalid_properties = array();
        if ($this->container['first_name'] === null) {
            $invalid_properties[] = "'first_name' can't be null";
        }
        if ($this->container['last_name'] === null) {
            $invalid_properties[] = "'last_name' can't be null";
        }
        if ($this->container['coin_balance'] === null) {
            $invalid_properties[] = "'coin_balance' can't be null";
        }
        if ($this->container['fiat_balance'] === null) {
            $invalid_properties[] = "'fiat_balance' can't be null";
        }
        if ($this->container['merchant_type'] === null) {
            $invalid_properties[] = "'merchant_type' can't be null";
        }
        if ($this->container['organization'] === null) {
            $invalid_properties[] = "'organization' can't be null";
        }
        if ($this->container['status'] === null) {
            $invalid_properties[] = "'status' can't be null";
        }
        if ($this->container['website'] === null) {
            $invalid_properties[] = "'website' can't be null";
        }
        if ($this->container['address'] === null) {
            $invalid_properties[] = "'address' can't be null";
        }
        if ($this->container['admin_email'] === null) {
            $invalid_properties[] = "'admin_email' can't be null";
        }
        if ($this->container['business_type'] === null) {
            $invalid_properties[] = "'business_type' can't be null";
        }
        if ($this->container['info'] === null) {
            $invalid_properties[] = "'info' can't be null";
        }
        if ($this->container['min_coin_settlement'] === null) {
            $invalid_properties[] = "'min_coin_settlement' can't be null";
        }
        if ($this->container['min_fiat_settlement'] === null) {
            $invalid_properties[] = "'min_fiat_settlement' can't be null";
        }
        if ($this->container['tel'] === null) {
            $invalid_properties[] = "'tel' can't be null";
        }
        return $invalid_properties;
    }

    /**
     * validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properteis are valid
     */
    public function valid()
    {
        if ($this->container['first_name'] === null) {
            return false;
        }
        if ($this->container['last_name'] === null) {
            return false;
        }
        if ($this->container['coin_balance'] === null) {
            return false;
        }
        if ($this->container['fiat_balance'] === null) {
            return false;
        }
        if ($this->container['merchant_type'] === null) {
            return false;
        }
        if ($this->container['organization'] === null) {
            return false;
        }
        if ($this->container['status'] === null) {
            return false;
        }
        if ($this->container['website'] === null) {
            return false;
        }
        if ($this->container['address'] === null) {
            return false;
        }
        if ($this->container['admin_email'] === null) {
            return false;
        }
        if ($this->container['business_type'] === null) {
            return false;
        }
        if ($this->container['info'] === null) {
            return false;
        }
        if ($this->container['min_coin_settlement'] === null) {
            return false;
        }
        if ($this->container['min_fiat_settlement'] === null) {
            return false;
        }
        if ($this->container['tel'] === null) {
            return false;
        }
        return true;
    }


    /**
     * Gets first_name
     * @return string
     */
    public function getFirstName()
    {
        return $this->container['first_name'];
    }

    /**
     * Sets first_name
     * @param string $first_name
     * @return $this
     */
    public function setFirstName($first_name)
    {
        $this->container['first_name'] = $first_name;

        return $this;
    }

    /**
     * Gets last_name
     * @return string
     */
    public function getLastName()
    {
        return $this->container['last_name'];
    }

    /**
     * Sets last_name
     * @param string $last_name
     * @return $this
     */
    public function setLastName($last_name)
    {
        $this->container['last_name'] = $last_name;

        return $this;
    }

    /**
     * Gets coin_balance
     * @return int
     */
    public function getCoinBalance()
    {
        return $this->container['coin_balance'];
    }

    /**
     * Sets coin_balance
     * @param int $coin_balance
     * @return $this
     */
    public function setCoinBalance($coin_balance)
    {
        $this->container['coin_balance'] = $coin_balance;

        return $this;
    }

    /**
     * Gets fiat_balance
     * @return int
     */
    public function getFiatBalance()
    {
        return $this->container['fiat_balance'];
    }

    /**
     * Sets fiat_balance
     * @param int $fiat_balance
     * @return $this
     */
    public function setFiatBalance($fiat_balance)
    {
        $this->container['fiat_balance'] = $fiat_balance;

        return $this;
    }

    /**
     * Gets merchant_type
     * @return string
     */
    public function getMerchantType()
    {
        return $this->container['merchant_type'];
    }

    /**
     * Sets merchant_type
     * @param string $merchant_type
     * @return $this
     */
    public function setMerchantType($merchant_type)
    {
        $this->container['merchant_type'] = $merchant_type;

        return $this;
    }

    /**
     * Gets organization
     * @return string
     */
    public function getOrganization()
    {
        return $this->container['organization'];
    }

    /**
     * Sets organization
     * @param string $organization
     * @return $this
     */
    public function setOrganization($organization)
    {
        $this->container['organization'] = $organization;

        return $this;
    }

    /**
     * Gets status
     * @return string
     */
    public function getStatus()
    {
        return $this->container['status'];
    }

    /**
     * Sets status
     * @param string $status
     * @return $this
     */
    public function setStatus($status)
    {
        $this->container['status'] = $status;

        return $this;
    }

    /**
     * Gets website
     * @return string
     */
    public function getWebsite()
    {
        return $this->container['website'];
    }

    /**
     * Sets website
     * @param string $website
     * @return $this
     */
    public function setWebsite($website)
    {
        $this->container['website'] = $website;

        return $this;
    }

    /**
     * Gets address
     * @return string
     */
    public function getAddress()
    {
        return $this->container['address'];
    }

    /**
     * Sets address
     * @param string $address
     * @return $this
     */
    public function setAddress($address)
    {
        $this->container['address'] = $address;

        return $this;
    }

    /**
     * Gets admin_email
     * @return string
     */
    public function getAdminEmail()
    {
        return $this->container['admin_email'];
    }

    /**
     * Sets admin_email
     * @param string $admin_email
     * @return $this
     */
    public function setAdminEmail($admin_email)
    {
        $this->container['admin_email'] = $admin_email;

        return $this;
    }

    /**
     * Gets business_type
     * @return string
     */
    public function getBusinessType()
    {
        return $this->container['business_type'];
    }

    /**
     * Sets business_type
     * @param string $business_type
     * @return $this
     */
    public function setBusinessType($business_type)
    {
        $this->container['business_type'] = $business_type;

        return $this;
    }

    /**
     * Gets info
     * @return string
     */
    public function getInfo()
    {
        return $this->container['info'];
    }

    /**
     * Sets info
     * @param string $info
     * @return $this
     */
    public function setInfo($info)
    {
        $this->container['info'] = $info;

        return $this;
    }

    /**
     * Gets min_coin_settlement
     * @return int
     */
    public function getMinCoinSettlement()
    {
        return $this->container['min_coin_settlement'];
    }

    /**
     * Sets min_coin_settlement
     * @param int $min_coin_settlement
     * @return $this
     */
    public function setMinCoinSettlement($min_coin_settlement)
    {
        $this->container['min_coin_settlement'] = $min_coin_settlement;

        return $this;
    }

    /**
     * Gets min_fiat_settlement
     * @return int
     */
    public function getMinFiatSettlement()
    {
        return $this->container['min_fiat_settlement'];
    }

    /**
     * Sets min_fiat_settlement
     * @param int $min_fiat_settlement
     * @return $this
     */
    public function setMinFiatSettlement($min_fiat_settlement)
    {
        $this->container['min_fiat_settlement'] = $min_fiat_settlement;

        return $this;
    }

    /**
     * Gets tel
     * @return string
     */
    public function getTel()
    {
        return $this->container['tel'];
    }

    /**
     * Sets tel
     * @param string $tel
     * @return $this
     */
    public function setTel($tel)
    {
        $this->container['tel'] = $tel;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     * @param  integer $offset Offset
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     * @param  integer $offset Offset
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     * @param  integer $offset Offset
     * @param  mixed   $value  Value to be set
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     * @param  integer $offset Offset
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(\Swagger\Client\ObjectSerializer::sanitizeForSerialization($this), JSON_PRETTY_PRINT);
        }

        return json_encode(\Swagger\Client\ObjectSerializer::sanitizeForSerialization($this));
    }
}

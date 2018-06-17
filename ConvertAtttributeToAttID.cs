//LDAP Query: (&(objectclass=attributeSchema)(lDAPDisplayName=*))

    private uint TransformOidToAttId(string attributeId, string name)
		{
			uint attId = 0;
			int pos = attributeId.LastIndexOf('.');
			string prefix = attributeId.Substring(0, pos);
			string lastDigit = attributeId.Substring(pos + 1);
			switch (prefix)
			{
				case "2.5.4":
					attId = 0;
					break;
				case "2.5.6":
					attId = 1;
					break;
				case "1.2.840.113556.1.2":
					attId = 2;
					break;
				case "1.2.840.113556.1.3":
					attId = 3;
					break;
				case "2.16.840.1.101.2.2.1":
					attId = 4;
					break;
				case "2.16.840.1.101.2.2.3":
					attId = 5;
					break;
				case "2.16.840.1.101.2.1.5":
					attId = 6;
					break;
				case "2.16.840.1.101.2.1.4":
					attId = 7;
					break;
				case "2.5.5":
					attId = 8;
					break;
				case "1.2.840.113556.1.4":
					attId = 9;
					break;
				case "1.2.840.113556.1.5":
					attId = 10;
					break;
				case "1.2.840.113556.1.4.260":
					attId = 11;
					break;
				case "1.2.840.113556.1.5.56":
					attId = 12;
					break;
				case "1.2.840.113556.1.4.262":
					attId = 13;
					break;
				case "1.2.840.113556.1.5.57":
					attId = 14;
					break;
				case "1.2.840.113556.1.4.263":
					attId = 15;
					break;
				case "1.2.840.113556.1.5.58":
					attId = 16;
					break;
				case "1.2.840.113556.1.5.73":
					attId = 17;
					break;
				case "1.2.840.113556.1.4.305":
					attId = 18;
					break;
				case "0.9.2342.19200300.100":
					attId = 19;
					break;
				case "2.16.840.1.113730.3":
					attId = 20;
					break;
				case "0.9.2342.19200300.100.1":
					attId = 21;
					break;
				case "2.16.840.1.113730.3.1":
					attId = 22;
					break;
				case "1.2.840.113556.1.5.7000":
					attId = 23;
					break;
				case "2.5.21":
					attId = 24;
					break;
				case "2.5.18":
					attId = 25;
					break;
				case "2.5.20":
					attId = 26;
					break;
				case "1.3.6.1.4.1.1466.101.119":
					attId = 27;
					break;
				case "2.16.840.1.113730.3.2":
					attId = 28;
					break;
				case "1.3.6.1.4.1.250.1":
					attId = 29;
					break;
				case "1.2.840.113549.1.9":
					attId = 30;
					break;
				case "0.9.2342.19200300.100.4":
					attId = 31;
					break;
				case "1.2.840.113556.1.6.23":
					attId = 32;
					break;
				case "1.2.840.113556.1.6.18.1":
					attId = 33;
					break;
				case "1.2.840.113556.1.6.18.2":
					attId = 34;
					break;
				case "1.2.840.113556.1.6.13.3":
					attId = 35;
					break;
				case "1.2.840.113556.1.6.13.4":
					attId = 36;
					break;
				case "1.3.6.1.1.1.1":
					attId = 37;
					break;
				case "1.3.6.1.1.1.2":
					attId = 38;
					break;
					
				default:
					return 0xFFFFFFFF;
			}
			attId = (attId * 0x10000) + Convert.ToUInt32(lastDigit);
			return attId;
		}

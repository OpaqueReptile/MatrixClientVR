{
  "account_data": {
    "events": [
      {
        "content": {
          "device": {},
          "global": {
            "content": [
              {
                "pattern": "python",
                "enabled": true,
                "rule_id": "python",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight"
                  }
                ]
              },
              {
                "pattern": "y'all",
                "enabled": true,
                "rule_id": "y'all",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight"
                  }
                ]
              },
              {
                "pattern": "zelda",
                "enabled": true,
                "rule_id": "zelda",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight"
                  }
                ]
              },
              {
                "default": true,
                "pattern": "preston",
                "enabled": true,
                "rule_id": ".m.rule.contains_user_name",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight"
                  }
                ]
              }
            ],
            "override": [
              {
                "default": true,
                "enabled": false,
                "conditions": [],
                "rule_id": ".m.rule.master",
                "actions": [
                  "dont_notify"
                ]
              },
              {
                "default": true,
                "enabled": false,
                "conditions": [
                  {
                    "pattern": "m.notice",
                    "kind": "event_match",
                    "key": "content.msgtype"
                  }
                ],
                "rule_id": ".m.rule.suppress_notices",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight",
                    "value": false
                  }
                ]
              },
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "pattern": "m.room.member",
                    "kind": "event_match",
                    "key": "type"
                  },
                  {
                    "pattern": "invite",
                    "kind": "event_match",
                    "key": "content.membership"
                  },
                  {
                    "pattern": "@preston:inferiorlattice.com",
                    "kind": "event_match",
                    "key": "state_key"
                  }
                ],
                "rule_id": ".m.rule.invite_for_me",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight",
                    "value": false
                  }
                ]
              },
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "pattern": "m.room.member",
                    "kind": "event_match",
                    "key": "type"
                  }
                ],
                "rule_id": ".m.rule.member_event",
                "actions": [
                  "dont_notify"
                ]
              },
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "kind": "contains_display_name"
                  }
                ],
                "rule_id": ".m.rule.contains_display_name",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight"
                  }
                ]
              }
            ],
            "sender": [],
            "room": [
              {
                "enabled": true,
                "rule_id": "!tRpSgFwNrhtFMQHStu:inferiorlattice.com",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  }
                ]
              },
              {
                "enabled": true,
                "rule_id": "!GZUiUTsOohGOgfzeNV:inferiorlattice.com",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  }
                ]
              }
            ],
            "underride": [
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "pattern": "m.call.invite",
                    "kind": "event_match",
                    "key": "type"
                  }
                ],
                "rule_id": ".m.rule.call",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "ring"
                  },
                  {
                    "set_tweak": "highlight",
                    "value": false
                  }
                ]
              },
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "kind": "room_member_count",
                    "is": "2"
                  },
                  {
                    "pattern": "m.room.message",
                    "kind": "event_match",
                    "key": "type"
                  }
                ],
                "rule_id": ".m.rule.room_one_to_one",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight",
                    "value": false
                  }
                ]
              },
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "kind": "room_member_count",
                    "is": "2"
                  },
                  {
                    "pattern": "m.room.encrypted",
                    "kind": "event_match",
                    "key": "type"
                  }
                ],
                "rule_id": ".m.rule.encrypted_room_one_to_one",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "sound",
                    "value": "default"
                  },
                  {
                    "set_tweak": "highlight",
                    "value": false
                  }
                ]
              },
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "pattern": "m.room.message",
                    "kind": "event_match",
                    "key": "type"
                  }
                ],
                "rule_id": ".m.rule.message",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "highlight",
                    "value": false
                  }
                ]
              },
              {
                "default": true,
                "enabled": true,
                "conditions": [
                  {
                    "pattern": "m.room.encrypted",
                    "kind": "event_match",
                    "key": "type"
                  }
                ],
                "rule_id": ".m.rule.encrypted",
                "actions": [
                  "notify",
                  {
                    "set_tweak": "highlight",
                    "value": false
                  }
                ]
              }
            ]
          }
        },
        "type": "m.push_rules"
      },
      {
        "content": {
          "theme": "dark",
          "MessageComposerInput.isRichTextEnabled": false,
          "MessageComposer.showFormatting": true
        },
        "type": "im.vector.web.settings"
      },
      {
        "content": {
          "@Karl:inferiorlattice.com": [
            "!OfEGTgRZdgqLBRvtxP:inferiorlattice.com",
            "!yGVzexedGluSpUyeQK:inferiorlattice.com"
          ],
          "@preston:inferiorlattice.com": [
            "!sakUhhSUTWQeiCijxI:inferiorlattice.com"
          ],
          "@tom:inferiorlattice.com": [],
          "@kbroeker:inferiorlattice.com": [
            "!JFlhFnCXmcvdPvSNdB:inferiorlattice.com"
          ],
          "@NotReallyCanada:inferiorlattice.com": [
            "!kouSXjySlzWmoatnoB:inferiorlattice.com"
          ]
        },
        "type": "m.direct"
      }
    ]
  },
  "to_device": {
    "events": []
  },
  "presence": {
    "events": [
      {
        "content": {
          "presence": "online",
          "last_active_ago": 7738,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@preston:inferiorlattice.com"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 1168141,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@am2on:atauno.com"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 256070,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@vurpo:vurpo.fi"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 367950,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@max:kamax.io"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 103816,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@erikj:jki.re"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 723919,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@aaron:raim.ist"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 7744,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@Karl:inferiorlattice.com"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 212483,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@travis:t2l.io"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 5948,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@tom:inferiorlattice.com"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 1006576,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@realitygaps:chat.weho.st"
      },
      {
        "content": {
          "presence": "online",
          "last_active_ago": 652369,
          "currently_active": true
        },
        "type": "m.presence",
        "sender": "@voyager:t2bot.io"
      }
    ]
  },
  "next_batch": "s70358_1489512_0_56039_103_110_105_5935",
  "rooms": {
    "leave": {},
    "join": {
      "!GyMcfzdsnhYfYaQeCu:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t8105-70331_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1491580616954,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915806162jMvXe:inferiorlattice.com",
              "unsigned": {
                "age": 4100776
              },
              "content": {
                "body": "Ohboyherewego",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491580621612,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915806213JyhtX:inferiorlattice.com",
              "unsigned": {
                "age": 4096118
              },
              "content": {
                "body": "trying to use eve online as an example oh how python is scalable",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491580635992,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915806354dndpl:inferiorlattice.com",
              "unsigned": {
                "age": 4081738
              },
              "content": {
                "body": "https://hackernoon.com/yes-python-is-slow-and-i-dont-care-13763980b5a1",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491580664272,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915806645dAYDl:inferiorlattice.com",
              "unsigned": {
                "age": 4053458
              },
              "content": {
                "body": "tldr; if you have unlimited VC funds who cares about speed when you can scale and who cares about maintainablity when you plan to cash out",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491581226126,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915812260aNWwL:inferiorlattice.com",
              "unsigned": {
                "age": 3491604
              },
              "content": {
                "body": "@karl",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491581228172,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915812281jsaPm:inferiorlattice.com",
              "unsigned": {
                "age": 3489558
              },
              "content": {
                "body": "https://doc.rust-lang.org/book/references-and-borrowing.html",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491581237981,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915812372UvRHH:inferiorlattice.com",
              "unsigned": {
                "age": 3479749
              },
              "content": {
                "body": "this is a really over overview on ownership",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491581248025,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915812480OwZZS:inferiorlattice.com",
              "unsigned": {
                "age": 3469705
              },
              "content": {
                "body": "and is better than my fragmented explanation",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491584120943,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915841200fKond:inferiorlattice.com",
              "unsigned": {
                "age": 596787
              },
              "content": {
                "body": "Preston location sharing is spooky",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491584365266,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915843650wRUuv:inferiorlattice.com",
              "unsigned": {
                "age": 352464
              },
              "content": {
                "body": "Kinda",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488428390779,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488428390128OdaNp:inferiorlattice.com",
              "unsigned": {
                "age": 3156326951,
                "replaces_state": "$1488428100105dmoWp:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488428390728,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488428390127MiRKD:inferiorlattice.com",
              "unsigned": {
                "age": 3156327002
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#shitpost:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488439775499,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488439775213xDqJY:inferiorlattice.com",
              "unsigned": {
                "age": 3144942231
              },
              "state_key": "",
              "content": {
                "url": "mxc://inferiorlattice.com/RfdIqcdxqVyAgMslzjECjlKq"
              },
              "type": "m.room.avatar"
            },
            {
              "origin_server_ts": 1488474752606,
              "sender": "@_neb_imgur:matrix.org",
              "event_id": "$148847475265035PDWkQ:matrix.org",
              "unsigned": {
                "age": 3109965124,
                "replaces_state": "$1488437726430424fJuwG:matrix.org"
              },
              "state_key": "@_neb_imgur:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/hcwlAYvWXvddOXiKdJrxBeYQ",
                "displayname": "Imgur"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488438618840,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488438618105jhuHD:inferiorlattice.com",
              "unsigned": {
                "age": 3146098890,
                "replaces_state": "$148843848799yofQU:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "name": "General"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488474667286,
              "sender": "@neb_giphy:matrix.org",
              "event_id": "$148847466763216SDNxg:matrix.org",
              "unsigned": {
                "age": 3110050444,
                "replaces_state": "$1488437700430316dAyRJ:matrix.org"
              },
              "state_key": "@neb_giphy:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/rdVTitpJMUrrJbWeNpHOeJsT",
                "displayname": "Giphy"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488434851085,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14884348513AjlFH:inferiorlattice.com",
              "unsigned": {
                "age": 3149866645,
                "replaces_state": "$14884348492GrEuU:inferiorlattice.com"
              },
              "state_key": "@NotReallyCanada:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/WJTwzJRxVkibReZwcftENzvX",
                "displayname": "NotReallyCanada"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488428390820,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488428390129FhvHs:inferiorlattice.com",
              "unsigned": {
                "age": 3156326910,
                "replaces_state": "$1488428100107WQFvi:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488428100351,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488428100104ppuqH:inferiorlattice.com",
              "unsigned": {
                "age": 3156617379
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488428100521,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488428100106RAFzn:inferiorlattice.com",
              "unsigned": {
                "age": 3156617209
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488428100234,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488428100102cJnaE:inferiorlattice.com",
              "unsigned": {
                "age": 3156617496
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488430172467,
              "sender": "@arcarr:inferiorlattice.com",
              "event_id": "$1488430172193oQwDY:inferiorlattice.com",
              "unsigned": {
                "age": 3154545263,
                "replaces_state": "$1488430150192KGLni:inferiorlattice.com"
              },
              "state_key": "@arcarr:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "Alexis"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488474753476,
              "sender": "@_neb_wikipedia:matrix.org",
              "event_id": "$148847475365115xDNwX:matrix.org",
              "unsigned": {
                "age": 3109964254,
                "replaces_state": "$1488437713430373HJkxO:matrix.org"
              },
              "state_key": "@_neb_wikipedia:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/NkKVqDsXRglcbcDCGFIfvYXt",
                "displayname": "Wikipedia"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488428587730,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488428587133lgrPO:inferiorlattice.com",
              "unsigned": {
                "age": 3156130000,
                "replaces_state": "$1488428100103wHoOy:inferiorlattice.com"
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489884540637,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$14898845405423KsvOQ:inferiorlattice.com",
              "unsigned": {
                "age": 1700177093,
                "replaces_state": "$1488487302241hpfzp:inferiorlattice.com"
              },
              "state_key": "@kbroeker:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/sIJzUDaesErqbNrXkxDShYSk",
                "displayname": "kayla"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488491669682,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488491669297TVDwd:inferiorlattice.com",
              "unsigned": {
                "age": 3093048048
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488436063704,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488436063119sBose:inferiorlattice.com",
              "unsigned": {
                "age": 3148654026,
                "replaces_state": "$1488435982112ceKUZ:inferiorlattice.com"
              },
              "state_key": "@165572:matrix.org",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491347188968,
              "sender": "@fs_IUd5TWNmemRzbmhZZllhUWVDdTppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "event_id": "$1491347188361978hfgHr:matrix.org",
              "unsigned": {
                "age": 237528762,
                "replaces_state": "$1491347158361746IONbA:matrix.org"
              },
              "state_key": "@fs_IUd5TWNmemRzbmhZZllhUWVDdTppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488928490423,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14889284901039VtoAt:inferiorlattice.com",
              "unsigned": {
                "age": 2656227307,
                "replaces_state": "$14889284711037lMmWh:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "topic": "The Internet was a mistake"
              },
              "type": "m.room.topic"
            },
            {
              "origin_server_ts": 1488435891854,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488435891108Ywbmn:inferiorlattice.com",
              "unsigned": {
                "age": 3148825876
              },
              "state_key": "PaXiYxvtHyAbUXbkmTlfBRwNErUiEiJQflvjGRlTMOKIBhyzOEAxLrxChLdWUjhpaPmsfDgrCyYzcyprUuqhZZIyIqvNcjWcRgAMaWXMVUWEDKtznbePABBgUyKCqQTn",
              "content": {
                "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA",
                "display_name": "pfr...@g.c...",
                "public_keys": [
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                    "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA"
                  },
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/ephemeral/isvalid",
                    "public_key": "Ux-4ukg4XrVjaVq0w5ccEwvuKps8c23fTGycqtmNXAg"
                  }
                ]
              },
              "type": "m.room.third_party_invite"
            },
            {
              "origin_server_ts": 1488875610982,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14888756106XoPqT:inferiorlattice.com",
              "unsigned": {
                "age": 2709106748,
                "replaces_state": "$1488428410131SPwWZ:inferiorlattice.com"
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14914217590kqKoY:inferiorlattice.com": {
                  "m.read": {
                    "@kbroeker:inferiorlattice.com": {
                      "ts": 1491421940259
                    }
                  }
                },
                "$14915843650wRUuv:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1491584365474
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1491584390310
                    }
                  }
                },
                "$14915812480OwZZS:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491581997456
                    }
                  }
                },
                "$14915307380xhXoT:inferiorlattice.com": {
                  "m.read": {
                    "@arcarr:inferiorlattice.com": {
                      "ts": 1491535295249
                    },
                    "@NotReallyCanada:inferiorlattice.com": {
                      "ts": 1491531720010
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": [
            {
              "content": {
                "tags": {
                  "m.favourite": {
                    "order": 0.375
                  }
                }
              },
              "type": "m.tag"
            },
            {
              "content": {
                "primary_color": "#81bddb",
                "secondary_color": "#eaf1f4"
              },
              "type": "org.matrix.room.color_scheme"
            }
          ]
        }
      },
      "!sakUhhSUTWQeiCijxI:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t47-39485_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1488466800819,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488466800233twDvX:inferiorlattice.com",
              "unsigned": {
                "age": 3117916911
              },
              "content": {
                "body": "You should be able to look at the logs and see failed connections might give you a clue as to what's up",
                "msgtype": "m.text",
                "formatted_body": "You should be able to look at the logs and see failed connections might give you a clue as to what&#39;s up",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488466970552,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488466970234jKuYO:inferiorlattice.com",
              "unsigned": {
                "age": 3117747178
              },
              "content": {
                "body": "I need to go to work and shit, will investigate in a bit",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488466982639,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488466982235cfoMI:inferiorlattice.com",
              "unsigned": {
                "age": 3117735091
              },
              "content": {
                "body": "Yup, no rush",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488466986464,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488466986236NuDQo:inferiorlattice.com",
              "unsigned": {
                "age": 3117731266
              },
              "content": {
                "body": "goal state is to have 443 proxied correctly",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488468145484,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488468145237bVJjf:inferiorlattice.com",
              "unsigned": {
                "age": 3116572246
              },
              "content": {
                "body": "Im also starting to suspect that I did need that voip thing",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488468161918,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488468161238YITrI:inferiorlattice.com",
              "unsigned": {
                "age": 3116555812
              },
              "content": {
                "body": "probably just using browser magic to do the point to point calls",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488875611216,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14888756117dZiRg:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "join",
                  "avatar_url": null,
                  "displayname": "tom"
                },
                "prev_sender": "@tom:inferiorlattice.com",
                "replaces_state": "$1488429023136GvAFh:inferiorlattice.com",
                "age": 2709106514
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488933166387,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14889331661081xTfxE:inferiorlattice.com",
              "unsigned": {
                "age": 2651551343
              },
              "content": {
                "body": "you should see if the tiwtter integration works now",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488933179752,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14889331791082juzES:inferiorlattice.com",
              "unsigned": {
                "age": 2651537978
              },
              "content": {
                "body": "I think I was having dns problems this evening",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488933186123,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14889331861083pfHJO:inferiorlattice.com",
              "unsigned": {
                "age": 2651531607
              },
              "content": {
                "body": "which fixed themselves after an update",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488429023303,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488429023138sjlQQ:inferiorlattice.com",
              "unsigned": {
                "age": 3155694427
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488429023390,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488429023139ccZAL:inferiorlattice.com",
              "unsigned": {
                "age": 3155694340
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488429023477,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488429023140eyeCr:inferiorlattice.com",
              "unsigned": {
                "age": 3155694253
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488429023094,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488429023135jhiwT:inferiorlattice.com",
              "unsigned": {
                "age": 3155694636
              },
              "state_key": "",
              "content": {
                "creator": "@tom:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488429033506,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429033142QLdNq:inferiorlattice.com",
              "unsigned": {
                "age": 3155684224,
                "replaces_state": "$1488429023141BtbuA:inferiorlattice.com"
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488429023208,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488429023137QMCfB:inferiorlattice.com",
              "unsigned": {
                "age": 3155694522
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100,
                  "@tom:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488436374065,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843637412hiaXx:inferiorlattice.com",
              "unsigned": {
                "age": 3148343665,
                "replaces_state": "$148843633311Ddura:inferiorlattice.com"
              },
              "state_key": "@165572:matrix.org",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488436322060,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14884363228LjuzY:inferiorlattice.com",
              "unsigned": {
                "age": 3148395670
              },
              "state_key": "KkbwJsojGgILFojFVPeBCgWpJOgWyGyGlCxisIqPwcAGnPpDyjyodSJEDjlfFlUddHkYbJLuGSpehpPqsfLsgRVfnOvBiegUoLbOMxCsiiMACIfuWIquSHclwYnaKVlF",
              "content": {
                "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA",
                "display_name": "pfr...@g.c...",
                "public_keys": [
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                    "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA"
                  },
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/ephemeral/isvalid",
                    "public_key": "iENQPyCtcfpaCw3tAKSHy1G79pgTAAkHrTGoYSmjIBA"
                  }
                ]
              },
              "type": "m.room.third_party_invite"
            },
            {
              "origin_server_ts": 1488436327221,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14884363279BWlKP:inferiorlattice.com",
              "unsigned": {
                "age": 3148390509
              },
              "state_key": "cIwIdfvhqXmpRmeathTbXzhAyRQDFMengIRXeMGhsCYxKZckgRGafUYEBXiCWtJHIwevJEvqjWQYqAZPHAOveKIvaMPMoINQFixGyFcaJKvrYbnGulISklIZPxFUDsUx",
              "content": {
                "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA",
                "display_name": "pfr...@g.c...",
                "public_keys": [
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                    "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA"
                  },
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/ephemeral/isvalid",
                    "public_key": "zmMRoNmPW3wWcOUB5u04UTApWNnbl_Ng8yskkZVfS6E"
                  }
                ]
              },
              "type": "m.room.third_party_invite"
            },
            {
              "origin_server_ts": 1488429023142,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488429023136GvAFh:inferiorlattice.com",
              "unsigned": {
                "age": 3155694588
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$1488466982235cfoMI:inferiorlattice.com": {
                  "m.read": {
                    "@tom:inferiorlattice.com": {
                      "ts": 1488466983223
                    }
                  }
                },
                "$14889331861083pfHJO:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1488933283047
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!ZyicGZmDOmhBdeSDqB:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t6-305_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1488435250721,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525046AWVoq:inferiorlattice.com",
              "unsigned": {
                "age": 3149467009
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488435250798,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525047FmwPH:inferiorlattice.com",
              "unsigned": {
                "age": 3149466932
              },
              "state_key": "",
              "content": {
                "name": "DotA2"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488435278899,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843527849idlOb:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "join_rule": "invite"
                },
                "prev_sender": "@preston:inferiorlattice.com",
                "replaces_state": "$148843525044jEDaS:inferiorlattice.com",
                "age": 3149438831
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488435278928,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843527850gNomy:inferiorlattice.com",
              "unsigned": {
                "age": 3149438802
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#dota2:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488435279009,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843527951nynfP:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "guest_access": "can_join"
                },
                "prev_sender": "@preston:inferiorlattice.com",
                "replaces_state": "$148843525046AWVoq:inferiorlattice.com",
                "age": 3149438721
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488492094723,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492094306OGmrx:inferiorlattice.com",
              "unsigned": {
                "age": 3092623007
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489493363814,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14894933633491bSzwt:inferiorlattice.com",
              "unsigned": {
                "age": 2091353916
              },
              "content": {
                "body": "ヽ(◉◡◔)ﾉ MY NAME IS SWINDLE, I DONT BAN MEEPO CUZ IM COOL ヽ(◉◡◔)ﾉ",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1489493377131,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14894933773492KcYoK:inferiorlattice.com",
              "unsigned": {
                "age": 2091340599
              },
              "content": {
                "body": "there's only one person to meme at in here",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1489493379415,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14894933793493bLpKO:inferiorlattice.com",
              "unsigned": {
                "age": 2091338315
              },
              "content": {
                "body": "that's far too few",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490993571004,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14909935710vsabj:inferiorlattice.com",
              "unsigned": {
                "age": 591146726
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488435250555,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525044jEDaS:inferiorlattice.com",
              "unsigned": {
                "age": 3149467175
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488435250721,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525046AWVoq:inferiorlattice.com",
              "unsigned": {
                "age": 3149467009
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488435250336,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525041BMzqu:inferiorlattice.com",
              "unsigned": {
                "age": 3149467394
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488435250393,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525042rClwV:inferiorlattice.com",
              "unsigned": {
                "age": 3149467337
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488435250468,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525043ikwaP:inferiorlattice.com",
              "unsigned": {
                "age": 3149467262
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488435250632,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843525045cxiEz:inferiorlattice.com",
              "unsigned": {
                "age": 3149467098
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14909935710vsabj:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491053649988
                    }
                  }
                },
                "$14894933793493bLpKO:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1489493949590
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1490993571397
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!qsWcJTleQNECQRiqva:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t140-409_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1488436889907,
              "sender": "@publicTom:matrix.org",
              "event_id": "$1488436889427396CwLUO:matrix.org",
              "unsigned": {
                "age": 3147827823
              },
              "content": {
                "body": "it's me",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488436891568,
              "sender": "@publicTom:matrix.org",
              "event_id": "$1488436891427405keUHP:matrix.org",
              "unsigned": {
                "age": 3147826162
              },
              "content": {
                "body": "your brother",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488436908358,
              "sender": "@165572:matrix.org",
              "event_id": "$1488436908427473JqYtm:matrix.org",
              "unsigned": {
                "prev_content": {
                  "third_party_invite": {
                    "display_name": "pfr...@g.c...",
                    "signed": {
                      "token": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
                      "signatures": {
                        "vector.im": {
                          "ed25519:0": "2WMK1eL8OS7XM/mcWBWtWjVuGJ7odDhBnPSUH0eHrRw4zVqZAETpVY2eOrxmg9EjbjRi+LeXeHUD3mrJe6lVCA"
                        }
                      },
                      "mxid": "@165572:matrix.org",
                      "sender": "@preston:inferiorlattice.com"
                    }
                  },
                  "membership": "invite"
                },
                "prev_sender": "@preston:inferiorlattice.com",
                "replaces_state": "$148843651123FNZbx:inferiorlattice.com",
                "age": 3147809372
              },
              "state_key": "@165572:matrix.org",
              "content": {
                "kind": "guest",
                "avatar_url": null,
                "displayname": "Guest 165572",
                "membership": "join",
                "third_party_signed": {
                  "token": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
                  "signatures": {
                    "vector.im": {
                      "ed25519:0": "2WMK1eL8OS7XM/mcWBWtWjVuGJ7odDhBnPSUH0eHrRw4zVqZAETpVY2eOrxmg9EjbjRi+LeXeHUD3mrJe6lVCA"
                    }
                  },
                  "mxid": "@165572:matrix.org",
                  "sender": "@preston:inferiorlattice.com"
                }
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488436979795,
              "sender": "@165572:matrix.org",
              "event_id": "$1488436979427732FMzyH:matrix.org",
              "unsigned": {
                "age": 3147737935
              },
              "content": {
                "body": "hullo",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488437548863,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843754843NOKtj:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "kind": "guest",
                  "avatar_url": null,
                  "displayname": "Guest 0",
                  "membership": "join"
                },
                "prev_sender": "@0:inferiorlattice.com",
                "replaces_state": "$148843672026tNSwd:inferiorlattice.com",
                "age": 3147168867
              },
              "state_key": "@0:inferiorlattice.com",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488437553352,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843755344Fqshb:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "kind": "guest",
                  "avatar_url": null,
                  "displayname": "Guest 165572",
                  "membership": "join",
                  "third_party_signed": {
                    "token": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
                    "signatures": {
                      "vector.im": {
                        "ed25519:0": "2WMK1eL8OS7XM/mcWBWtWjVuGJ7odDhBnPSUH0eHrRw4zVqZAETpVY2eOrxmg9EjbjRi+LeXeHUD3mrJe6lVCA"
                      }
                    },
                    "mxid": "@165572:matrix.org",
                    "sender": "@preston:inferiorlattice.com"
                  }
                },
                "prev_sender": "@165572:matrix.org",
                "replaces_state": "$1488436908427473JqYtm:matrix.org",
                "age": 3147164378
              },
              "state_key": "@165572:matrix.org",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488437528363,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488437528429707xAUZN:matrix.org",
              "unsigned": {
                "prev_content": {
                  "membership": "leave"
                },
                "prev_sender": "@preston:inferiorlattice.com",
                "age": 3147189362,
                "invite_room_state": [
                  {
                    "content": {
                      "name": "TestRoomPleaseIgnore"
                    },
                    "type": "m.room.name",
                    "sender": "@tom:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "alias": "#testroom:inferiorlattice.com"
                    },
                    "type": "m.room.canonical_alias",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "membership": "join",
                      "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                      "displayname": "preston"
                    },
                    "type": "m.room.member",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": "@preston:inferiorlattice.com"
                  },
                  {
                    "content": {
                      "join_rule": "public"
                    },
                    "type": "m.room.join_rules",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  }
                ],
                "replaces_state": "$148843755344Fqshb:inferiorlattice.com"
              },
              "state_key": "@165572:matrix.org",
              "content": {
                "third_party_invite": {
                  "display_name": "pfr...@g.c...",
                  "signed": {
                    "token": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
                    "signatures": {
                      "vector.im": {
                        "ed25519:0": "2WMK1eL8OS7XM/mcWBWtWjVuGJ7odDhBnPSUH0eHrRw4zVqZAETpVY2eOrxmg9EjbjRi+LeXeHUD3mrJe6lVCA"
                      }
                    },
                    "mxid": "@165572:matrix.org",
                    "sender": "@preston:inferiorlattice.com"
                  }
                },
                "membership": "invite"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488437528564,
              "sender": "@165572:matrix.org",
              "event_id": "$1488437528429708ILNEt:matrix.org",
              "unsigned": {
                "prev_content": {
                  "third_party_invite": {
                    "display_name": "pfr...@g.c...",
                    "signed": {
                      "token": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
                      "signatures": {
                        "vector.im": {
                          "ed25519:0": "2WMK1eL8OS7XM/mcWBWtWjVuGJ7odDhBnPSUH0eHrRw4zVqZAETpVY2eOrxmg9EjbjRi+LeXeHUD3mrJe6lVCA"
                        }
                      },
                      "mxid": "@165572:matrix.org",
                      "sender": "@preston:inferiorlattice.com"
                    }
                  },
                  "membership": "invite"
                },
                "prev_sender": "@preston:inferiorlattice.com",
                "replaces_state": "$1488437528429707xAUZN:matrix.org",
                "age": 3147189166
              },
              "state_key": "@165572:matrix.org",
              "content": {
                "kind": "guest",
                "avatar_url": null,
                "displayname": "Guest 165572",
                "membership": "join",
                "third_party_signed": {
                  "token": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
                  "signatures": {
                    "vector.im": {
                      "ed25519:0": "2WMK1eL8OS7XM/mcWBWtWjVuGJ7odDhBnPSUH0eHrRw4zVqZAETpVY2eOrxmg9EjbjRi+LeXeHUD3mrJe6lVCA"
                    }
                  },
                  "mxid": "@165572:matrix.org",
                  "sender": "@preston:inferiorlattice.com"
                }
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488476325556,
              "sender": "@166107:matrix.org",
              "event_id": "$148847632579224SajuO:matrix.org",
              "unsigned": {
                "age": 3108392174
              },
              "state_key": "@166107:matrix.org",
              "content": {
                "kind": "guest",
                "avatar_url": null,
                "displayname": "Guest 166107",
                "membership": "join"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488875610903,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14888756105kjFGR:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "join",
                  "avatar_url": null,
                  "displayname": "tom"
                },
                "prev_sender": "@tom:inferiorlattice.com",
                "replaces_state": "$1488428410130Fwbwd:inferiorlattice.com",
                "age": 2709106827
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488429142754,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429142146aVjCw:inferiorlattice.com",
              "unsigned": {
                "age": 3155574976,
                "replaces_state": "$1488428306113pdiuz:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488436720761,
              "sender": "@0:inferiorlattice.com",
              "event_id": "$148843672026tNSwd:inferiorlattice.com",
              "unsigned": {
                "age": 3147996969
              },
              "state_key": "@0:inferiorlattice.com",
              "content": {
                "kind": "guest",
                "avatar_url": null,
                "displayname": "Guest 0",
                "membership": "join"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488428306533,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488428306115iGnpx:inferiorlattice.com",
              "unsigned": {
                "age": 3156411197
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#testroom:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488436011020,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488436011113ajboX:inferiorlattice.com",
              "unsigned": {
                "age": 3148706710
              },
              "state_key": "ACDhuRpTqinyXNMuqgpkBXUQcnpTHXFwflTObYjkAGbpizaJwrhNXnnfQDKCfIDVerGLwgluUmOUnTDCivaaGnGyCPHhNjkBIluEAblkajGYUcofcmExmyzHigYKTDFD",
              "content": {
                "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA",
                "display_name": "pfr...@g.c...",
                "public_keys": [
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                    "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA"
                  },
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/ephemeral/isvalid",
                    "public_key": "3MTDPMeKBy_soNCEH9-RRzMyx9cCvQZh6CAP8hZZ0ME"
                  }
                ]
              },
              "type": "m.room.third_party_invite"
            },
            {
              "origin_server_ts": 1488436918603,
              "sender": "@publicTom:matrix.org",
              "event_id": "$1488436880427363ikfIt:matrix.org",
              "unsigned": {
                "prev_content": {
                  "membership": "invite",
                  "avatar_url": null,
                  "displayname": null
                },
                "age": 5,
                "replaces_state": "$148843689429ZLwVg:inferiorlattice.com",
                "prev_sender": "@tom:inferiorlattice.com"
              },
              "state_key": "@publicTom:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "publicTom"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488427267398,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$148842726712PdTJk:inferiorlattice.com",
              "unsigned": {
                "age": 3157450332
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488427267098,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14884272678zcnrY:inferiorlattice.com",
              "unsigned": {
                "age": 3157450632
              },
              "state_key": "",
              "content": {
                "creator": "@tom:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488429070037,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429070144eETfj:inferiorlattice.com",
              "unsigned": {
                "age": 3155647693,
                "replaces_state": "$1488429058143sgZRL:inferiorlattice.com"
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488427946677,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$148842794690DNGQn:inferiorlattice.com",
              "unsigned": {
                "age": 3156771053,
                "replaces_state": "$148842726710dIwuX:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100,
                  "@tom:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488436511516,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843651123FNZbx:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "leave"
                },
                "prev_sender": "@165572:matrix.org",
                "age": 3148206203,
                "invite_room_state": [
                  {
                    "content": {
                      "name": "TestRoomPleaseIgnore"
                    },
                    "type": "m.room.name",
                    "sender": "@tom:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "alias": "#testroom:inferiorlattice.com"
                    },
                    "type": "m.room.canonical_alias",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "membership": "join",
                      "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                      "displayname": "preston"
                    },
                    "type": "m.room.member",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": "@preston:inferiorlattice.com"
                  },
                  {
                    "content": {
                      "join_rule": "public"
                    },
                    "type": "m.room.join_rules",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  }
                ],
                "replaces_state": "$1488436212424993Rrmuw:matrix.org"
              },
              "state_key": "@165572:matrix.org",
              "content": {
                "third_party_invite": {
                  "display_name": "pfr...@g.c...",
                  "signed": {
                    "token": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
                    "signatures": {
                      "vector.im": {
                        "ed25519:0": "2WMK1eL8OS7XM/mcWBWtWjVuGJ7odDhBnPSUH0eHrRw4zVqZAETpVY2eOrxmg9EjbjRi+LeXeHUD3mrJe6lVCA"
                      }
                    },
                    "mxid": "@165572:matrix.org",
                    "sender": "@preston:inferiorlattice.com"
                  }
                },
                "membership": "invite"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488429091056,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429091145ndAEQ:inferiorlattice.com",
              "unsigned": {
                "age": 3155626674
              },
              "state_key": "",
              "content": {
                "alias": "#testroom:inferiorlattice.com"
              },
              "type": "m.room.canonical_alias"
            },
            {
              "origin_server_ts": 1488431255994,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488431255218ghLux:inferiorlattice.com",
              "unsigned": {
                "age": 3153461736,
                "replaces_state": "$1488429142147HgmAt:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488436497757,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843649721wbFrT:inferiorlattice.com",
              "unsigned": {
                "age": 3148219973
              },
              "state_key": "tLwjqxXPDDptzwvFyfnMelLKfaAnxKMKNcaLBhfQLwzgQDVTBHWrJFqKOATNJBfSOFhdjArXyyJVBfIkRbvyXEDHwGgaZtJEwxJeyUNaVCjQVQmEXTXYsRTxBufqpvyH",
              "content": {
                "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA",
                "display_name": "pfr...@g.c...",
                "public_keys": [
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/isvalid",
                    "public_key": "LKd2ww8OslLxmzKShqFvCV4U7xGTcWjq4VDQXYGgdzA"
                  },
                  {
                    "key_validity_url": "https://vector.im/_matrix/identity/api/v1/pubkey/ephemeral/isvalid",
                    "public_key": "_fe1AoisAx3nvhph-yIaIQcfA5WhuPHp8foRAZnLLo8"
                  }
                ]
              },
              "type": "m.room.third_party_invite"
            },
            {
              "origin_server_ts": 1488427267577,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$148842726714YPzTj:inferiorlattice.com",
              "unsigned": {
                "age": 3157450153
              },
              "state_key": "",
              "content": {
                "name": "TestRoomPleaseIgnore"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488428410646,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488428410130Fwbwd:inferiorlattice.com",
              "unsigned": {
                "age": 3156307084,
                "replaces_state": "$14884272679BJKHj:inferiorlattice.com"
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$1488436979427732FMzyH:matrix.org": {
                  "m.read": {
                    "@tom:inferiorlattice.com": {
                      "ts": 1488437577322
                    },
                    "@publicTom:matrix.org": {
                      "ts": 1488437247839
                    }
                  }
                },
                "$14888756105kjFGR:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1490838608925
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": [
            {
              "content": {
                "tags": {
                  "m.lowpriority": {}
                }
              },
              "type": "m.tag"
            }
          ]
        }
      },
      "!DAAAnEOGyytxIxsdoz:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t519-69975_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1491531537551,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915315374EmYSy:inferiorlattice.com",
              "unsigned": {
                "age": 53180179
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwggEsABH8dRyS7fHtAsWZOvMXYp+oc0pEKVBY6Udt9hp+RNz6i5Dh1dYyCdVAaaG4svhqpLZ+n3YlYrVyfLdqbHdTe1Rwj9bM1jnLGwRdimWndAdEk8NK/vRyO+4rg3MrHb3APJLFz2sJuqg0ExAZ5J3OtQMa6jOvKRLCTUjTac4MZ/RHtPcUMhEdItTT3/yZFsu341QnOGk2CKQHoPWfRz0YJpmNbKR/bgb1Bqe+SYeeyrBssM7xEe9vZrooIScP48tNHTmkm3J5hSdxEHvfYCV3rh9SNjg0ep66A4TuMy6tUpmSkeAl+XpD7quiZWt3Md5FLmF3BhxoskhttJt3KQD9CKidxfJ8+sx7oL",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491531774622,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915317740TIhXO:inferiorlattice.com",
              "unsigned": {
                "age": 52943108
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwghEoAB3oTFX3YRPfH1ehQYR0LDCcePyYHYWHx+5ZCYNjjYdI5zh9f+so5sSA8cb/gXYPUjgw2NFMdy3OS+ptriFGKsg7LewFyYTtsg3u/PHgei8aV1LEdAIWgnFfl2DQbDXFwMjDJf0Pfs1bpc7i7uCuQXO8aW9W4J29iCgNJ37af3XhWtLjSQE4HmJDWzJxq7Fxp2sfI7t8TserHbhEwgR6yfzabaLi4musO+EPLs6rcSuKMJ/oci3rG75kbtc4/xzST1jONFTe7Y5QI",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491531776905,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915317761fPkLu:inferiorlattice.com",
              "unsigned": {
                "age": 52940825
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwgiEpABDwWLPhpVUuwGgKfVpekuwh16ebV39uuytGIQPFBQCBQdKkzt7UgGomaPxXYZQINDD6GJB/0KkMyp6zKsPGjIu9UpG6GQAKT0H31TDvQsqzHNw4hA1fp60MrTS1QZ6b1i1Oc8ovb3T9pDaamIDURSkP0U+F17/DAl6FsRf6C0r2SbS9iQDsoIWat7bKkgkX4AqwYI2XYnnzCf08bqFtfyqPMdRoi6IH5MQH/VS9C7oglCH84kaNWD6b60/3YeGe1DKOm9cWXPUV08nkuTecu6CgthRb37Bg8L",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491531802342,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915318022qiNRP:inferiorlattice.com",
              "unsigned": {
                "age": 52915388
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwgjEvABKrC2iID8okUJU+cMa0YLfyliBx5M5rDCjwDuXdovOgmKj6aJyGsZhFb15XTQ7Cj6dSpFmteVI7wO5TZOIXUSXi6B9Oshpmfv0VEw4zAjTuHTh37YZfceLA4Kl6WP/e552aziWlnFv/dTxCt9wgDMBr2AmyDNPCqAX1o3OAQFj9Do9MHMspdypn5TZHpsjQS0cfMk8rjT1ob0RABd1txXyKMWLFyaKEAde/5BbUuBRkVhRCNe5pD0ko+TVCIToeYg7FVbjm8zOij6nO1bn8iJJU6OQQVr/r7Q9p6moeHJkaeMj5+BaKHUWwLX6YfxRIb/nc1PezbkOmKUyNRbouZcWt4AmLY6M/yZmPg18dIvvm7Bhpmn1h651mUulYDOnjlkwHyRNkZXHH7TDM/ZbcNc3YSCukShBMkF",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491531808561,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915318083ZNkQY:inferiorlattice.com",
              "unsigned": {
                "age": 52909169
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwgkEpABOe4sWV4ROKulFgnuywSiIK/lUGqUPoBhk6BjHCmIv7e8WmIWo95Y+r3o2LbctZvvH5LFqsI6bP3vEsIRRM3UFGqk1WOZ8MbXvYNlxQ8Ee+Nd+95cgsoEWwa7zyGJlfsz83rR5v6eZQOmN/qCNJNafaGuDBut5s23+wKRg2psgtFQV3rmGUnywvOHAC8isPj57rpLILSCH5prYzp+D+kQDj6bgO/A46wHekgWTi4Z3+17xZxCUKe+P1NJAtY+PaSFIGotDjauqmoTARY/YeUvAIwW4dQb0XcP",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491532431488,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915324310SDQdb:inferiorlattice.com",
              "unsigned": {
                "age": 52286242
              },
              "content": {
                "sender_key": "cYzcsd0ToefoN8dUV6zCIKLOXsN7KsAR5w5Eu8Dr2Wg",
                "ciphertext": "AwgSEsABay/mpBaN7O21Tms/Y1n0lRiUkS+LwjPgt+Eo+UGAMTXbS7KZraiydp0hNM2n2/+kVXt1unbb3qok0gSd5iA6I7kjiq2F9k6WOSLRTX4IM9ynma9mmBdj1FK8v8A+xTkH0PdfKtq1km7SdE7kkqcw8R7Wb4PXBES/wIiR3g+xmMEIe/hfI8pAPUHHmq9Yqp4DkLItXDbjiEO0hs+dMUATON/KLVmMA7euLJ2ii7dNCmgGsXQjkYzEnRCBDLlARU2nNzWfTUB6gTQsbpDn/5vjvyGUg32wggdW2uxk5w1cGTa1O+fxCBN59qQBptaRQYXZVF0D6pWa/ndxT/tN45m+AYk+pcdzUXkL",
                "session_id": "R7BEMN7iXG6RV+Ag/fSF3lNL2dEe1Ju2vZ41QQcivnA",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "XMFKMSTCSC"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491532625652,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915326250bEvWb:inferiorlattice.com",
              "unsigned": {
                "age": 52092078
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwglErABT9ghWyXZhNRUuyr/uCJpmKdGnM0fPWuR2y89bbd8Y+aFXWcmzYme35hW/pCyJqc5K3k5f2wc+SjgfKQtbhnPmp4o9b3s3UbSyeSa7Oh9ybRf886wvCTq/qJs3xTpgBwL/pi83BbWWorzAdvvEG/rDKIQr83n4r46XNS/uId2NQazI3k83bbkmZ0Q/FC+x1bGz1nV5dBA3tpPQH4fMapN8YIbql8LJDB5ShSOBBYsfZWSOqFoPE1wJ7ArZxccibthL/7j9woZX8OMEu/Bx2urYQ2vMciQGMp3O98i5u7mjUJREqz+h4OrHGpHGzV6TOPfxwxgpJidxQs",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491532714615,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915327140pliRh:inferiorlattice.com",
              "unsigned": {
                "age": 52003115
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwgmEsAB2oFBNiVBF/a0zuwfdan0Ceq6QhNq/Tp/LBwM8hh4IOe6v3RY1xpGxCTrB042bgsWEsgLcrQnmG2DNQvLmS/EyBAaViFXO1xGhbjnbTthRRnk2c5YfNAHbJ004pwIIctcmrAnRgWIJ13TjnpbUhueOfTemBpkNrmnpk1v4Xerl7i2ptfH3VWQXK91rGMQmAQtjmMSQkpUFTVKONxMbmBwF2R2+sur8Rc8OUGkvtDg8iolVS3mgsiC+jANvWcRPW/It+5Eg9Sp4BJW/KqSB8JxxUUT4Q4y909DLeLqfwfGUzqg8q3KrN+dUWx9OsDh9QaEy9yiViIEHGuF6tE9jY5BT0HaTlH+1VcK",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491532729409,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14915327291lbmfj:inferiorlattice.com",
              "unsigned": {
                "age": 51988321
              },
              "content": {
                "sender_key": "dU0ZaHWfgKhJzhPI9SzCuhtpVgPyFED+O5AOjKsEeH0",
                "ciphertext": "AwgnEqAB55o5DhJaA3aZOYxbwxXndYgt6WLvO88vbv42l2er8wxcI27O0C5enMY99CetTjN23zRw7K7l1kNqdVHzoFmPmHJ8+xkTcrMn9aeDfcld6plw/NW+rPbAGHY6Iy0/X2PFLSxuvXLGcR1O7beOoEJGQjxFrxrMHqrair0JPSqkRXsMRPvbskB0prNNqcoF02ejqPdxBMCvlEnoThz1t+LhT9fcQHBEd95Daeb9pOhqAb8IJC7daRfHi4iaF9PlT+xQ0CcMEMJJ9baX6c7gfzdoAwK9sRrF7FhYMLQ8y12xlmLI+vXZhHWsAg",
                "session_id": "tNFKubkYR3OZ4nSt2IawbAwWLD3tu/ZqvGxgH4h1Lyo",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "PVLSZQZOXS"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1491569996428,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14915699960BefBI:inferiorlattice.com",
              "unsigned": {
                "age": 14721302
              },
              "content": {
                "sender_key": "zF1xSgCSR2cZMH4tra4xwUdE7gaEOFUfNTqz2ovsRGQ",
                "ciphertext": "AwgAEqABoxQjZSeZuw65DK6cYMkr4a9NVyemrHqWHgG9LzcfPlGZC/ryz/yslSC8bq8C8txCqsOvyxRu07kVy9D4FuCzBo9K5ODKMTXGcmvxkwP93H/TNIhAB0kwnvlZIRp5s1DXRCR3uTBiF8BTJ+Nv+hwANwpe1sLBX2/Qluj/OxqaUs7MWAexxrRlhZ02/jR484vU5stchw48RL1If1R615HBoexX9EGf5NeQ/rLB/xQ9Vxu7Cu49JA7vJmedHiG0PQYgtQ/gJp0fjgADMhyakfkN8tp17GVDIG2bWvIq9U77f/uZvL74rEGLCw",
                "session_id": "KBDPtMcbuDy4JKpGiA3IKsxTcVSCil9tO4+SODWZke0",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "FJDWJLUTVQ"
              },
              "type": "m.room.encrypted"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488898509101,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889850932eeTdm:inferiorlattice.com",
              "unsigned": {
                "age": 2686208629,
                "replaces_state": "$148889847326lHGiD:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488898509071,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889850930GHCQF:inferiorlattice.com",
              "unsigned": {
                "age": 2686208659
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#politics:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488898473613,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889847329xTrcI:inferiorlattice.com",
              "unsigned": {
                "age": 2686244117
              },
              "state_key": "",
              "content": {
                "name": "Politics"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488900462204,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148890046296asigX:inferiorlattice.com",
              "unsigned": {
                "age": 2684255526
              },
              "state_key": "",
              "content": {
                "algorithm": "m.megolm.v1.aes-sha2"
              },
              "type": "m.room.encryption"
            },
            {
              "origin_server_ts": 1488898509168,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889850933roStx:inferiorlattice.com",
              "unsigned": {
                "age": 2686208562,
                "replaces_state": "$148889847328BAGGM:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488898473040,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889847323PUqqO:inferiorlattice.com",
              "unsigned": {
                "age": 2686244690
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488898473104,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889847324oIOFi:inferiorlattice.com",
              "unsigned": {
                "age": 2686244626
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488898473191,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889847325BKOXd:inferiorlattice.com",
              "unsigned": {
                "age": 2686244539
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488900837591,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488900837124zCIfd:inferiorlattice.com",
              "unsigned": {
                "age": 2683880139
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488898509082,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889850931MqbIE:inferiorlattice.com",
              "unsigned": {
                "age": 2686208648
              },
              "state_key": "",
              "content": {
                "alias": "#politics:inferiorlattice.com"
              },
              "type": "m.room.canonical_alias"
            },
            {
              "origin_server_ts": 1491530784652,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915307841bCeiK:inferiorlattice.com",
              "unsigned": {
                "age": 53933078
              },
              "state_key": "",
              "content": {
                "topic": "https://twitter.com/realDonaldTrump/status/375609403376144384"
              },
              "type": "m.room.topic"
            },
            {
              "origin_server_ts": 1488898473419,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148889847327xTvEd:inferiorlattice.com",
              "unsigned": {
                "age": 2686244311
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488901506489,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488901506153LTTZm:inferiorlattice.com",
              "unsigned": {
                "age": 2683211241
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14915327291lbmfj:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491566528156
                    }
                  }
                },
                "$14915699960BefBI:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1491570374761
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1491572179070
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": [
            {
              "content": {
                "primary_color": "#bb814e",
                "secondary_color": "#eee8e3"
              },
              "type": "org.matrix.room.color_scheme"
            }
          ]
        }
      },
      "!GZUiUTsOohGOgfzeNV:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t1245-68758_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1491448883348,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149144888310zDBAR:inferiorlattice.com",
              "unsigned": {
                "age": 135834382
              },
              "content": {
                "body": "upgrading projects is a bit painful",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491448976423,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914489761UgYnX:inferiorlattice.com",
              "unsigned": {
                "age": 135741307
              },
              "content": {
                "body": "5.6.0f3?",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491449513716,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14914495131qjHdo:inferiorlattice.com",
              "unsigned": {
                "age": 135204014
              },
              "content": {
                "body": "sounds good to me",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491449539018,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14914495392IaBXN:inferiorlattice.com",
              "unsigned": {
                "age": 135178712
              },
              "content": {
                "body": "so how i make it go",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491449698335,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914496980ZjFUO:inferiorlattice.com",
              "unsigned": {
                "age": 135019395
              },
              "content": {
                "body": "point unity at the directory and it should recognize it as a project",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491449782674,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14914497821FVyRF:inferiorlattice.com",
              "unsigned": {
                "age": 134935056
              },
              "content": {
                "body": "yeah i opened it",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491449801892,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914498012QXeKf:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "leave"
                },
                "prev_sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
                "age": 134915838,
                "invite_room_state": [
                  {
                    "content": {
                      "join_rule": "public"
                    },
                    "type": "m.room.join_rules",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "url": "mxc://inferiorlattice.com/shYPLvEyQlJjJHXBluoPQZXS"
                    },
                    "type": "m.room.avatar",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "name": "Tech Support"
                    },
                    "type": "m.room.name",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "membership": "join",
                      "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                      "displayname": "preston"
                    },
                    "type": "m.room.member",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": "@preston:inferiorlattice.com"
                  }
                ],
                "replaces_state": "$1491349358381587yCJlG:matrix.org"
              },
              "state_key": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "content": {
                "membership": "invite",
                "avatar_url": null,
                "displayname": "VoIP Conference"
              },
              "membership": "invite",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491449802872,
              "sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "event_id": "$1491449753577738pkQPT:matrix.org",
              "unsigned": {
                "prev_content": {
                  "membership": "invite",
                  "avatar_url": null,
                  "displayname": "VoIP Conference"
                },
                "age": 25,
                "replaces_state": "$14914498012QXeKf:inferiorlattice.com",
                "prev_sender": "@preston:inferiorlattice.com"
              },
              "state_key": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "VoIP Conference"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491451111378,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14914511112BhfFr:inferiorlattice.com",
              "unsigned": {
                "age": 133606352
              },
              "content": {
                "body": "https://msdn.microsoft.com/en-us/library/ff963556.aspx",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491451550154,
              "sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "event_id": "$1491451550591366GtbuV:matrix.org",
              "unsigned": {
                "prev_content": {
                  "membership": "join",
                  "avatar_url": null,
                  "displayname": "VoIP Conference"
                },
                "prev_sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
                "replaces_state": "$1491449753577738pkQPT:matrix.org",
                "age": 133167576
              },
              "state_key": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488431474717,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431474231IkWyt:inferiorlattice.com",
              "unsigned": {
                "age": 3153243013,
                "replaces_state": "$1488431443226Qcvqx:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488431474627,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431474230RpPIg:inferiorlattice.com",
              "unsigned": {
                "age": 3153243103
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#techsupport:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488440295892,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488440295222tGPcg:inferiorlattice.com",
              "unsigned": {
                "age": 3144421838,
                "replaces_state": "$1488440037215sWCHE:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "url": "mxc://inferiorlattice.com/shYPLvEyQlJjJHXBluoPQZXS"
              },
              "type": "m.room.avatar"
            },
            {
              "origin_server_ts": 1488431443505,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431443229rrtGo:inferiorlattice.com",
              "unsigned": {
                "age": 3153274225
              },
              "state_key": "",
              "content": {
                "name": "Tech Support"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1491349358911,
              "sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "event_id": "$1491349358381587yCJlG:matrix.org",
              "unsigned": {
                "age": 235358819,
                "replaces_state": "$1491348321372628NRQCN:matrix.org"
              },
              "state_key": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1490662374914,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14906623740HQYEr:inferiorlattice.com",
              "unsigned": {
                "age": 922342816,
                "replaces_state": "$148843497218qSWiH:inferiorlattice.com"
              },
              "state_key": "@NotReallyCanada:inferiorlattice.com",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488431474764,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431474232PKyqW:inferiorlattice.com",
              "unsigned": {
                "age": 3153242966,
                "replaces_state": "$1488431443228reXvh:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488431442986,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431442223asbfl:inferiorlattice.com",
              "unsigned": {
                "age": 3153274744
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488431443043,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431443224OWVEl:inferiorlattice.com",
              "unsigned": {
                "age": 3153274687
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488431443126,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431443225JTYPh:inferiorlattice.com",
              "unsigned": {
                "age": 3153274604
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1491347199122,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14913471995UTABo:inferiorlattice.com",
              "unsigned": {
                "age": 237518608
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488431443327,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488431443227HFYFl:inferiorlattice.com",
              "unsigned": {
                "age": 3153274403
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488875611472,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14888756119QthFv:inferiorlattice.com",
              "unsigned": {
                "age": 2709106258,
                "replaces_state": "$148843509624sfFew:inferiorlattice.com"
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14906622422xKsrS:inferiorlattice.com": {
                  "m.read": {
                    "@NotReallyCanada:inferiorlattice.com": {
                      "ts": 1490662353987
                    }
                  }
                },
                "$1491451550591366GtbuV:matrix.org": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491480284068
                    },
                    "@preston:inferiorlattice.com": {
                      "ts": 1491451600764
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1491485997583
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": [
            {
              "content": {
                "primary_color": "#e55e5e",
                "secondary_color": "#f5eaea"
              },
              "type": "org.matrix.room.color_scheme"
            }
          ]
        }
      },
      "!dgUpZZsqXNgIrgERas:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t250-59524_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1490317476228,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14903174768190jhhHh:inferiorlattice.com",
              "unsigned": {
                "age": 1267241502
              },
              "content": {
                "body": "I just need the smooth voice of seth green flying my ship or I get uncomfortable",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490317499219,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14903174998191SgEat:inferiorlattice.com",
              "unsigned": {
                "age": 1267218511
              },
              "content": {
                "body": "I keep hearing the voice of random Salarians from the Citadel when he speaks. ",
                "msgtype": "m.text",
                "formatted_body": "I keep hearing the voice of random Salarians from the Citadel when he speaks.",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490317536517,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14903175368192bTcjl:inferiorlattice.com",
              "unsigned": {
                "age": 1267181213
              },
              "content": {
                "body": "New Krogan guy is like Older Southern Wrex. ",
                "msgtype": "m.text",
                "formatted_body": "New Krogan guy is like Older Southern Wrex.",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490317583670,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14903175838193JugKJ:inferiorlattice.com",
              "unsigned": {
                "age": 1267134060
              },
              "content": {
                "body": "New Asari is not half bad either. ",
                "msgtype": "m.text",
                "formatted_body": "New Asari is not half bad either.",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490317628510,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14903176288194ALdla:inferiorlattice.com",
              "unsigned": {
                "age": 1267089220
              },
              "content": {
                "body": "I had my first hiccup though. New big baddies had a group of mobs get stuck in a rock formation. Ripped through my shields like crazy. ",
                "msgtype": "m.text",
                "formatted_body": "I had my first hiccup though. New big baddies had a group of mobs get stuck in a rock formation. Ripped through my shields like crazy.",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490470475982,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14904704758688rLiVr:inferiorlattice.com",
              "unsigned": {
                "age": 1114241748
              },
              "content": {
                "body": "Quarians got a flat on way to Andromeda. They were bringing along Drell, Hanar, and others. They won't be seen for \"a while\"",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490470486434,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14904704868689zbbCZ:inferiorlattice.com",
              "unsigned": {
                "age": 1114231296
              },
              "content": {
                "body": "I.e. Please look forward to it. ",
                "msgtype": "m.text",
                "formatted_body": "I.e. Please look forward to it.",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490470523090,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14904705238690AKMkn:inferiorlattice.com",
              "unsigned": {
                "age": 1114194640
              },
              "content": {
                "body": "\"Having to account for so many biological needs resulted in complications\"",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490493048879,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14904930488715xsFtl:inferiorlattice.com",
              "unsigned": {
                "age": 1091668851
              },
              "content": {
                "body": "ima_cdd890d.jpeg",
                "info": {
                  "mimetype": "image/jpeg",
                  "h": 3024,
                  "w": 4032,
                  "size": 4127057
                },
                "msgtype": "m.image",
                "url": "mxc://inferiorlattice.com/hRBnPHkZBAjJSOlTulUkVCEh"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490493050396,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14904930508716tpBnN:inferiorlattice.com",
              "unsigned": {
                "age": 1091667334
              },
              "content": {
                "body": "This parking job though. ",
                "msgtype": "m.text",
                "formatted_body": "This parking job though.",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488429700844,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429700163ZIroG:inferiorlattice.com",
              "unsigned": {
                "age": 3155016886,
                "replaces_state": "$1488429609159uBGWB:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488429700870,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429700164eFknn:inferiorlattice.com",
              "unsigned": {
                "age": 3155016860
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#masseffect:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488429932793,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429932191GGqVu:inferiorlattice.com",
              "unsigned": {
                "age": 3154784937
              },
              "state_key": "",
              "content": {
                "url": "mxc://inferiorlattice.com/jTpqZMvxXWlWfHWgCOBTCVza"
              },
              "type": "m.room.avatar"
            },
            {
              "origin_server_ts": 1488429609798,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429609162lnAfI:inferiorlattice.com",
              "unsigned": {
                "age": 3155107932
              },
              "state_key": "",
              "content": {
                "name": "Mass Effect"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488434969722,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$148843496917DETVg:inferiorlattice.com",
              "unsigned": {
                "age": 3149748008
              },
              "state_key": "@NotReallyCanada:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/WJTwzJRxVkibReZwcftENzvX",
                "displayname": "NotReallyCanada"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488429609628,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429609160mIJEg:inferiorlattice.com",
              "unsigned": {
                "age": 3155108102
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488429609309,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429609156wKVTb:inferiorlattice.com",
              "unsigned": {
                "age": 3155108421
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488758530114,
              "sender": "@arcarr:inferiorlattice.com",
              "event_id": "$1488758530699GsRuv:inferiorlattice.com",
              "unsigned": {
                "age": 2826187616
              },
              "state_key": "@arcarr:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "Alexis"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488429609365,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429609157NwGce:inferiorlattice.com",
              "unsigned": {
                "age": 3155108365
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488429609455,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429609158QILKz:inferiorlattice.com",
              "unsigned": {
                "age": 3155108275
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488429700896,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429700165MPHzK:inferiorlattice.com",
              "unsigned": {
                "age": 3155016834,
                "replaces_state": "$1488429609161wBFjd:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488875612559,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$148887561214umlqX:inferiorlattice.com",
              "unsigned": {
                "age": 2709105171,
                "replaces_state": "$1488603347584fPVpp:inferiorlattice.com"
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14903169418184RsFry:inferiorlattice.com": {
                  "m.read": {
                    "@NotReallyCanada:inferiorlattice.com": {
                      "ts": 1490317297085
                    }
                  }
                },
                "$14904930508716tpBnN:inferiorlattice.com": {
                  "m.read": {
                    "@arcarr:inferiorlattice.com": {
                      "ts": 1490493351713
                    },
                    "@preston:inferiorlattice.com": {
                      "ts": 1490497369032
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1490498484138
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!lgyfNUbkqARnkHHvvO:inferiorlattice.com": {
        "unread_notifications": {},
        "timeline": {
          "limited": true,
          "prev_batch": "t16-67791_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1491348368334,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913483684uAERO:inferiorlattice.com",
              "unsigned": {
                "age": 236349396
              },
              "content": {
                "lifetime": 60000,
                "offer": {
                  "type": "offer",
                  "sdp": "v=0\r\no=- 8396167979080169174 2 IN IP4 127.0.0.1\r\ns=-\r\nt=0 0\r\na=group:BUNDLE audio\r\na=msid-semantic: WMS pwNGZpgUE8idVZB5STg0fIfZ5JPf5GqEc4ZZ\r\nm=audio 52172 UDP/TLS/RTP/SAVPF 111 103 104 9 0 8 106 105 13 126\r\nc=IN IP4 192.168.56.1\r\na=rtcp:9 IN IP4 0.0.0.0\r\na=candidate:1416336954 1 udp 2122255103 2001::9d38:6ab8:1c8f:32d0:be43:c63c 52171 typ host generation 0 network-id 1 network-cost 50\r\na=candidate:2999745851 1 udp 2122194687 192.168.56.1 52172 typ host generation 0 network-id 3\r\na=candidate:1176891032 1 udp 2122129151 192.168.1.140 52173 typ host generation 0 network-id 2\r\na=ice-ufrag:/OIg\r\na=ice-pwd:M4cnCvobhwxl/J1lM/Tj7SNY\r\na=fingerprint:sha-256 8D:E4:3E:4B:8D:A7:1F:FB:1F:8B:89:91:73:24:E5:AA:2F:7C:E7:47:CC:90:26:9B:A8:59:A5:4B:C7:D6:42:A3\r\na=setup:actpass\r\na=mid:audio\r\na=extmap:1 urn:ietf:params:rtp-hdrext:ssrc-audio-level\r\na=extmap:3 http://www.webrtc.org/experiments/rtp-hdrext/abs-send-time\r\na=sendrecv\r\na=rtcp-mux\r\na=rtpmap:111 opus/48000/2\r\na=rtcp-fb:111 transport-cc\r\na=fmtp:111 minptime=10;useinbandfec=1\r\na=rtpmap:103 ISAC/16000\r\na=rtpmap:104 ISAC/32000\r\na=rtpmap:9 G722/8000\r\na=rtpmap:0 PCMU/8000\r\na=rtpmap:8 PCMA/8000\r\na=rtpmap:106 CN/32000\r\na=rtpmap:105 CN/16000\r\na=rtpmap:13 CN/8000\r\na=rtpmap:126 telephone-event/8000\r\na=ssrc:997923320 cname:odgZcpGbJ+Vkq0MV\r\na=ssrc:997923320 msid:pwNGZpgUE8idVZB5STg0fIfZ5JPf5GqEc4ZZ 7d0c3267-7416-4288-9251-818f0061499e\r\na=ssrc:997923320 mslabel:pwNGZpgUE8idVZB5STg0fIfZ5JPf5GqEc4ZZ\r\na=ssrc:997923320 label:7d0c3267-7416-4288-9251-818f0061499e\r\n"
                },
                "version": 0,
                "call_id": "c1491348320312"
              },
              "type": "m.call.invite"
            },
            {
              "origin_server_ts": 1491348368432,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913483685qtyxB:inferiorlattice.com",
              "unsigned": {
                "age": 236349298
              },
              "content": {
                "version": 0,
                "candidates": [
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1416336954 1 udp 2122255103 2001::9d38:6ab8:1c8f:32d0:be43:c63c 52171 typ host generation 0 ufrag /OIg network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:2999745851 1 udp 2122194687 192.168.56.1 52172 typ host generation 0 ufrag /OIg network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1176891032 1 udp 2122129151 192.168.1.140 52173 typ host generation 0 ufrag /OIg network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1416336954 2 udp 2122255102 2001::9d38:6ab8:1c8f:32d0:be43:c63c 52174 typ host generation 0 ufrag /OIg network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:2999745851 2 udp 2122194686 192.168.56.1 52175 typ host generation 0 ufrag /OIg network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1176891032 2 udp 2122129150 192.168.1.140 52176 typ host generation 0 ufrag /OIg network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:3345868844 1 udp 1685921535 65.188.57.195 52173 typ srflx raddr 192.168.1.140 rport 52173 generation 0 ufrag /OIg network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:3345868844 2 udp 1685921534 65.188.57.195 52176 typ srflx raddr 192.168.1.140 rport 52176 generation 0 ufrag /OIg network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:451439306 1 tcp 1518275327 2001::9d38:6ab8:1c8f:32d0:be43:c63c 9 typ host tcptype active generation 0 ufrag /OIg network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:4233069003 1 tcp 1518214911 192.168.56.1 9 typ host tcptype active generation 0 ufrag /OIg network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:145101416 1 tcp 1518149375 192.168.1.140 9 typ host tcptype active generation 0 ufrag /OIg network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:451439306 2 tcp 1518275326 2001::9d38:6ab8:1c8f:32d0:be43:c63c 9 typ host tcptype active generation 0 ufrag /OIg network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:4233069003 2 tcp 1518214910 192.168.56.1 9 typ host tcptype active generation 0 ufrag /OIg network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:145101416 2 tcp 1518149374 192.168.1.140 9 typ host tcptype active generation 0 ufrag /OIg network-id 2",
                    "sdpMLineIndex": 0
                  }
                ],
                "call_id": "c1491348320312"
              },
              "type": "m.call.candidates"
            },
            {
              "origin_server_ts": 1491348321588,
              "sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "event_id": "$1491348321372637RNmMm:matrix.org",
              "unsigned": {
                "age": 236396142
              },
              "content": {
                "answer": {
                  "type": "answer",
                  "sdp": "v=0\r\no=FreeSWITCH 1491322303 1491322304 IN IP4 83.166.69.14\r\ns=FreeSWITCH\r\nc=IN IP4 83.166.69.14\r\nt=0 0\r\na=msid-semantic: WMS zVcIXViKlsPpk1l5MgimXoY6OMkfFg15\r\na=end-of-candidates\r\nm=audio 26018 UDP/TLS/RTP/SAVPF 111 126\r\na=rtpmap:111 opus/48000/2\r\na=fmtp:111 useinbandfec=1; usedtx=1; minptime=10\r\na=rtpmap:126 telephone-event/8000\r\na=silenceSupp:off - - - -\r\na=ptime:20\r\na=sendrecv\r\na=fingerprint:sha-256 5A:77:2F:EA:AC:BD:15:11:2F:2A:49:E0:28:7B:E3:AD:B8:11:76:B1:A1:C0:99:01:6E:62:42:92:33:1C:F5:46\na=setup:active\r\na=rtcp-mux\r\na=rtcp:26018 IN IP4 83.166.69.14\r\na=ice-ufrag:yjLlyAiccthIz8Er\r\na=ice-pwd:287HLnyGhFM4WMtkV5wjvEmy\r\na=candidate:7061576174 1 udp 659136 83.166.69.14 26018 typ host generation 0\r\na=ssrc:3974870785 cname:23EPPMp154gfWraz\r\na=ssrc:3974870785 msid:zVcIXViKlsPpk1l5MgimXoY6OMkfFg15 a0\r\na=ssrc:3974870785 mslabel:zVcIXViKlsPpk1l5MgimXoY6OMkfFg15\r\na=ssrc:3974870785 label:zVcIXViKlsPpk1l5MgimXoY6OMkfFg15a0\r\n"
                },
                "version": 0,
                "call_id": "c1491348320312"
              },
              "type": "m.call.answer"
            },
            {
              "origin_server_ts": 1491349406594,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913494060OLxkq:inferiorlattice.com",
              "unsigned": {
                "age": 235311136
              },
              "content": {
                "version": 0,
                "call_id": "c1491348320312"
              },
              "type": "m.call.hangup"
            },
            {
              "origin_server_ts": 1491449802577,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914498023vimfT:inferiorlattice.com",
              "unsigned": {
                "age": 134915153
              },
              "content": {
                "lifetime": 60000,
                "offer": {
                  "type": "offer",
                  "sdp": "v=0\r\no=- 1506288296478874961 2 IN IP4 127.0.0.1\r\ns=-\r\nt=0 0\r\na=group:BUNDLE audio\r\na=msid-semantic: WMS EKfURcv7vdvc7gndpayKPIqu5QYTIeekwOhk\r\nm=audio 9 UDP/TLS/RTP/SAVPF 111 103 104 9 0 8 106 105 13 126\r\nc=IN IP4 0.0.0.0\r\na=rtcp:9 IN IP4 0.0.0.0\r\na=ice-ufrag:Q01g\r\na=ice-pwd:GxphMRIgvgxB25ITCU1momS2\r\na=fingerprint:sha-256 47:5E:01:69:0C:17:93:E9:1E:59:E6:17:1F:05:61:3C:84:D5:7F:E7:51:9D:FD:81:C0:AE:80:2E:DA:86:14:B7\r\na=setup:actpass\r\na=mid:audio\r\na=extmap:1 urn:ietf:params:rtp-hdrext:ssrc-audio-level\r\na=extmap:3 http://www.webrtc.org/experiments/rtp-hdrext/abs-send-time\r\na=sendrecv\r\na=rtcp-mux\r\na=rtpmap:111 opus/48000/2\r\na=rtcp-fb:111 transport-cc\r\na=fmtp:111 minptime=10;useinbandfec=1\r\na=rtpmap:103 ISAC/16000\r\na=rtpmap:104 ISAC/32000\r\na=rtpmap:9 G722/8000\r\na=rtpmap:0 PCMU/8000\r\na=rtpmap:8 PCMA/8000\r\na=rtpmap:106 CN/32000\r\na=rtpmap:105 CN/16000\r\na=rtpmap:13 CN/8000\r\na=rtpmap:126 telephone-event/8000\r\na=ssrc:3315142197 cname:J0CByICppq0NSjep\r\na=ssrc:3315142197 msid:EKfURcv7vdvc7gndpayKPIqu5QYTIeekwOhk 16f53535-5d1a-49c5-aa20-6863b9008db6\r\na=ssrc:3315142197 mslabel:EKfURcv7vdvc7gndpayKPIqu5QYTIeekwOhk\r\na=ssrc:3315142197 label:16f53535-5d1a-49c5-aa20-6863b9008db6\r\n"
                },
                "version": 0,
                "call_id": "c1491449753261"
              },
              "type": "m.call.invite"
            },
            {
              "origin_server_ts": 1491449802732,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914498024ZlDZm:inferiorlattice.com",
              "unsigned": {
                "age": 134914998
              },
              "content": {
                "version": 0,
                "candidates": [
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1416336954 1 udp 2122255103 2001::9d38:6ab8:1c8f:32d0:be43:c63c 52848 typ host generation 0 ufrag Q01g network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:2999745851 1 udp 2122194687 192.168.56.1 52849 typ host generation 0 ufrag Q01g network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1176891032 1 udp 2122129151 192.168.1.140 52850 typ host generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1416336954 2 udp 2122255102 2001::9d38:6ab8:1c8f:32d0:be43:c63c 52851 typ host generation 0 ufrag Q01g network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:2999745851 2 udp 2122194686 192.168.56.1 52852 typ host generation 0 ufrag Q01g network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1176891032 2 udp 2122129150 192.168.1.140 52853 typ host generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:3345868844 1 udp 1685921535 65.188.57.195 52850 typ srflx raddr 192.168.1.140 rport 52850 generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:3345868844 2 udp 1685921534 65.188.57.195 52853 typ srflx raddr 192.168.1.140 rport 52853 generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:451439306 1 tcp 1518275327 2001::9d38:6ab8:1c8f:32d0:be43:c63c 9 typ host tcptype active generation 0 ufrag Q01g network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:4233069003 1 tcp 1518214911 192.168.56.1 9 typ host tcptype active generation 0 ufrag Q01g network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:145101416 1 tcp 1518149375 192.168.1.140 9 typ host tcptype active generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:451439306 2 tcp 1518275326 2001::9d38:6ab8:1c8f:32d0:be43:c63c 9 typ host tcptype active generation 0 ufrag Q01g network-id 1 network-cost 50",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:4233069003 2 tcp 1518214910 192.168.56.1 9 typ host tcptype active generation 0 ufrag Q01g network-id 3",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:145101416 2 tcp 1518149374 192.168.1.140 9 typ host tcptype active generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  }
                ],
                "call_id": "c1491449753261"
              },
              "type": "m.call.candidates"
            },
            {
              "origin_server_ts": 1491449802812,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914498025YkLAG:inferiorlattice.com",
              "unsigned": {
                "age": 134914918
              },
              "content": {
                "version": 0,
                "candidates": [
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1289566162 1 udp 41754623 192.168.1.12 54295 typ relay raddr 65.188.57.195 rport 52850 generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:1289566162 2 udp 41754622 192.168.1.12 53422 typ relay raddr 65.188.57.195 rport 52853 generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  }
                ],
                "call_id": "c1491449753261"
              },
              "type": "m.call.candidates"
            },
            {
              "origin_server_ts": 1491449802838,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914498026ulLZb:inferiorlattice.com",
              "unsigned": {
                "age": 134914892
              },
              "content": {
                "version": 0,
                "candidates": [
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:39766818 1 udp 24977151 192.168.1.12 54490 typ relay raddr 65.188.57.195 rport 59727 generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  },
                  {
                    "sdpMid": "audio",
                    "candidate": "candidate:39766818 2 udp 24977150 192.168.1.12 51862 typ relay raddr 65.188.57.195 rport 59734 generation 0 ufrag Q01g network-id 2",
                    "sdpMLineIndex": 0
                  }
                ],
                "call_id": "c1491449753261"
              },
              "type": "m.call.candidates"
            },
            {
              "origin_server_ts": 1491449754157,
              "sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "event_id": "$1491449754577743AmBrp:matrix.org",
              "unsigned": {
                "age": 134963573
              },
              "content": {
                "answer": {
                  "type": "answer",
                  "sdp": "v=0\r\no=FreeSWITCH 1491430866 1491430867 IN IP4 83.166.69.14\r\ns=FreeSWITCH\r\nc=IN IP4 83.166.69.14\r\nt=0 0\r\na=msid-semantic: WMS 1s1AkJ2WsKfvkkBcdzLhnnTGWG4296A0\r\na=end-of-candidates\r\nm=audio 18888 UDP/TLS/RTP/SAVPF 111 126\r\na=rtpmap:111 opus/48000/2\r\na=fmtp:111 useinbandfec=1; usedtx=1; minptime=10\r\na=rtpmap:126 telephone-event/8000\r\na=silenceSupp:off - - - -\r\na=ptime:20\r\na=sendrecv\r\na=fingerprint:sha-256 5A:77:2F:EA:AC:BD:15:11:2F:2A:49:E0:28:7B:E3:AD:B8:11:76:B1:A1:C0:99:01:6E:62:42:92:33:1C:F5:46\na=setup:active\r\na=rtcp-mux\r\na=rtcp:18888 IN IP4 83.166.69.14\r\na=ice-ufrag:xHOKUyhG4cz490Uo\r\na=ice-pwd:ibOak1l4kRXNPTldqZObnVIi\r\na=candidate:9951878735 1 udp 659136 83.166.69.14 18888 typ host generation 0\r\na=ssrc:3975582250 cname:psqA2inkTsG3D75H\r\na=ssrc:3975582250 msid:1s1AkJ2WsKfvkkBcdzLhnnTGWG4296A0 a0\r\na=ssrc:3975582250 mslabel:1s1AkJ2WsKfvkkBcdzLhnnTGWG4296A0\r\na=ssrc:3975582250 label:1s1AkJ2WsKfvkkBcdzLhnnTGWG4296A0a0\r\n"
                },
                "version": 0,
                "call_id": "c1491449753261"
              },
              "type": "m.call.answer"
            },
            {
              "origin_server_ts": 1491451599345,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914515991cTWpA:inferiorlattice.com",
              "unsigned": {
                "age": 133118385
              },
              "content": {
                "version": 0,
                "call_id": "c1491449753261"
              },
              "type": "m.call.hangup"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1491347246184,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149134724648OmsaX:inferiorlattice.com",
              "unsigned": {
                "age": 237471546
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1491347247930,
              "sender": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "event_id": "$1491347200362069rVIsz:matrix.org",
              "unsigned": {
                "prev_content": {
                  "membership": "invite",
                  "avatar_url": null,
                  "displayname": "VoIP Conference"
                },
                "age": 14,
                "replaces_state": "$149134724651NjTFJ:inferiorlattice.com",
                "prev_sender": "@preston:inferiorlattice.com"
              },
              "state_key": "@fs_IUdaVWlVVHNPb2hHT2dmemVOVjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "VoIP Conference"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491347246266,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149134724649buUCt:inferiorlattice.com",
              "unsigned": {
                "age": 237471464
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1491347246012,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149134724645OMGip:inferiorlattice.com",
              "unsigned": {
                "age": 237471718
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1491347246069,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149134724646ThYLj:inferiorlattice.com",
              "unsigned": {
                "age": 237471661
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491347246118,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149134724647GiggH:inferiorlattice.com",
              "unsigned": {
                "age": 237471612
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1491347246360,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149134724650ljGZj:inferiorlattice.com",
              "unsigned": {
                "age": 237471370
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            }
          ]
        },
        "ephemeral": {
          "events": []
        },
        "account_data": {
          "events": []
        }
      },
      "!kouSXjySlzWmoatnoB:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": false,
          "prev_batch": "s70358_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1488435339836,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843533955cZpLJ:inferiorlattice.com",
              "unsigned": {
                "age": 3149377894
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488435339898,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843533956uAWLm:inferiorlattice.com",
              "unsigned": {
                "age": 3149377832
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488435339982,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843533957AnzYH:inferiorlattice.com",
              "unsigned": {
                "age": 3149377748
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100,
                  "@NotReallyCanada:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488435340073,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843534058HFXmA:inferiorlattice.com",
              "unsigned": {
                "age": 3149377657
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488435340164,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843534059eYpnS:inferiorlattice.com",
              "unsigned": {
                "age": 3149377566
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488435340252,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843534060VZDCd:inferiorlattice.com",
              "unsigned": {
                "age": 3149377478
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488435340355,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843534061GdFed:inferiorlattice.com",
              "unsigned": {
                "age": 3149377375,
                "invite_room_state": [
                  {
                    "content": {
                      "join_rule": "invite"
                    },
                    "type": "m.room.join_rules",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "membership": "join",
                      "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                      "displayname": "preston"
                    },
                    "type": "m.room.member",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": "@preston:inferiorlattice.com"
                  }
                ]
              },
              "state_key": "@NotReallyCanada:inferiorlattice.com",
              "content": {
                "membership": "invite",
                "avatar_url": "mxc://inferiorlattice.com/WJTwzJRxVkibReZwcftENzvX",
                "displayname": "NotReallyCanada",
                "is_direct": true
              },
              "membership": "invite",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488435346700,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$148843534663PmIGM:inferiorlattice.com",
              "unsigned": {
                "age": 3149371030
              },
              "content": {
                "body": "private chat ahoy",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488435484711,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$148843548472fAvCt:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "invite",
                  "avatar_url": "mxc://inferiorlattice.com/WJTwzJRxVkibReZwcftENzvX",
                  "displayname": "NotReallyCanada",
                  "is_direct": true
                },
                "prev_sender": "@preston:inferiorlattice.com",
                "replaces_state": "$148843534061GdFed:inferiorlattice.com",
                "age": 3149233019
              },
              "state_key": "@NotReallyCanada:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/WJTwzJRxVkibReZwcftENzvX",
                "displayname": "NotReallyCanada"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "state": {
          "events": []
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$148843534061GdFed:inferiorlattice.com": {
                  "m.read": {
                    "@NotReallyCanada:inferiorlattice.com": {
                      "ts": 1488435482912
                    }
                  }
                },
                "$148843548472fAvCt:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1488435912933
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!OfEGTgRZdgqLBRvtxP:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t578-59080_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1490236948269,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14902369487961wEGUu:inferiorlattice.com",
              "unsigned": {
                "age": 1347769461
              },
              "content": {
                "sender_key": "49zBXyYPOlHgx8a7KbpuQQHoTAQ0XJAPQ312RO+f9Uo",
                "ciphertext": "AwgDEqABNFoyPDtr2Ayl0+4t0zSTDqU8XsL6Uoby4X+gELI65Jl2DyCN2KzsGIequWzw1IDAD9dsf+aW1nJVA2fm+V7MWfq6vTptUylJGBJIp+oK5aj+Q/q1w61bfNIyiYsse50BXErtAOZDggRyufkXEhT9jr8wf8uiZCAMy6RZV1h5gQVvhC7ckhcWs7qCjGGI91zMOqeWyezFhvSZDLQqHOeKFW75NzdUNczgEs5gyHhS1DpRX9EZR11iTUEn3rwj/cWthtJtK8H35ckJdHqko9lkU1bZsx/uwFkO+NTkavDVzE6BfcyXgrM5AQ",
                "session_id": "/lx+I9dOQNHqyuFrruTy2aNwnTy5ynnXOdk3Q99uV6M",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "DCDSRVVHHK"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490830111315,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14908301110qWVRC:inferiorlattice.com",
              "unsigned": {
                "age": 754606415
              },
              "content": {
                "sender_key": "cYzcsd0ToefoN8dUV6zCIKLOXsN7KsAR5w5Eu8Dr2Wg",
                "ciphertext": "AwgAEqAB5Evq5H14zTEuCV2i+ErkdbzX3vZor2OH9agmXpPXoWUH6wWmB9dYLqRQcuGwfOWyNA6ZPbOO4P8emqI/R3UCpRRB1k3Z5Evdf8ZJ0sDF9rEecdVZsFr8qwlbYi7NT1Myqd/fCRE3CAmA8qflIjj1gniDIasMEraAswWOb4BzlZJ7RA+wDx8n8Sp/9PmeAUA23yvvebO376JDQoKyEwVn/p4uHue2SVGKIt3rMh7jVUrTwqgLI3iSzhvPurNvukufjVR+eLaz1faB3wwBvHZtzMbkiuuEr/u4KUw7KU82Akw/zmpE0MLTDQ",
                "session_id": "p9biILBNuRe7ZzVQoqs6SCG9SNG6oGJvibPuGN6RwoQ",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "XMFKMSTCSC"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490830112779,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14908301121idHbB:inferiorlattice.com",
              "unsigned": {
                "age": 754604951
              },
              "content": {
                "sender_key": "cYzcsd0ToefoN8dUV6zCIKLOXsN7KsAR5w5Eu8Dr2Wg",
                "ciphertext": "AwgBEoABjh52WIynHW6pPH/Re3Bgn8PgomGXwOujffDdz+wrEBYIKEV72Aw7SFWHVvKVR5GL244EDz+FKYi0qAago9fYaRoPqF5kLVNJmWjjzdnxwjH+xWeD+qMTSdmf8mfQeaVkcMhgzOlnI2cx78fhnpuUCeAdstJj0/S315NFQXzJD13T7nWmUC/JI+UdozdbzPejoDWfD/eYR8s43NnqaKCUxw3mh1UNHX8YkhCRSTebJ3TT66/jYkr+8JC7LMs4BMfPNFTn2rjkQww",
                "session_id": "p9biILBNuRe7ZzVQoqs6SCG9SNG6oGJvibPuGN6RwoQ",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "XMFKMSTCSC"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490830118173,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14908301182qTDIc:inferiorlattice.com",
              "unsigned": {
                "age": 754599557
              },
              "content": {
                "sender_key": "49zBXyYPOlHgx8a7KbpuQQHoTAQ0XJAPQ312RO+f9Uo",
                "ciphertext": "AwgAEoAB0usOC9Q2Fq/5w5vP1gywwNC4fgYOKOQuudjsuUHHeqWfQJSEqjyBG9OMUfJ4nPEVseAH8d/cxcyvmTcQvtnp/XzLlRISRBBvu4mppKjXDTZ49AEmX2oR83XuOfl2I7ALovG+jWcZJ8ItNuouT+QWDUNnkuoShL4IInq1mvNQ4zzI15NzviEedaeGyooRGWfL8Ckyx+kxu6MKLYn0h+n1nWuNGxxHhsi/h2B0h+W8R0drzkzP66RgHLl3PkxTx6EnWBb5Q3vyAQ4",
                "session_id": "NM8gS/xwc7C40h6ESailV8GKA1x32wP2DCWYr1GA598",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "DCDSRVVHHK"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490830130200,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14908301303gfQNX:inferiorlattice.com",
              "unsigned": {
                "age": 754587530
              },
              "content": {
                "sender_key": "cYzcsd0ToefoN8dUV6zCIKLOXsN7KsAR5w5Eu8Dr2Wg",
                "ciphertext": "AwgCErABSaV0fe9D+byZD8T75pjh1285m2f1Ujf11Qt2QMKI9adgcFUvbeydfphYcOpp/n7NwEZKXdvzPkGzDltUVWM6pidAUVANURwTAtimx4RY5mFsP7OmbNUMLoJoez4/81QD2CUEdA1/2T8c/n9M90nE2Pyl64jq1PWbEg2aHLJLcVtIPL+JegrlrFLnl/Vw+P1toD5cb8dZ1ytebMBBbiM8ulE5vuo3Wp4LQ1xEIVuYz+MwfOLF/VPu/JLKZl9rmgoUcw3GWngmcadlCWooxJnNFx9N52pGTaHMP3JaiGmLhE4O9V3v0oS423jM62DqdsoskxWsvG5NVAE",
                "session_id": "p9biILBNuRe7ZzVQoqs6SCG9SNG6oGJvibPuGN6RwoQ",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "XMFKMSTCSC"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490830189251,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14908301890VxDZW:inferiorlattice.com",
              "unsigned": {
                "age": 754528479
              },
              "content": {
                "sender_key": "49zBXyYPOlHgx8a7KbpuQQHoTAQ0XJAPQ312RO+f9Uo",
                "ciphertext": "AwgBEoABmZplzRpqoMa1KvsNs+p8GHUCSvr8WW+Et9amibyi1isoKpz5faS5ADJ8OvUPPMJIXxnU94AeuM8RehqESzOa+u/OF9O27ll2HusB1mthS45wtC71/wWUFPOpD11OOm9fiMYImAQygdbP+m7GdUjuXEO9UodBU4ptEmMb65HFSY5U5tcGNqhZYi48i83G+mFiX4xHXPAeT/NBTRxcicvgjmiKpC85yL7cSrx6p8BiXAspHNMhNAKZ/LOlmSRtaUNBDkRNZqfj9wk",
                "session_id": "NM8gS/xwc7C40h6ESailV8GKA1x32wP2DCWYr1GA598",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "DCDSRVVHHK"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490923132788,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$149092313211xeNne:inferiorlattice.com",
              "unsigned": {
                "age": 661584942
              },
              "content": {
                "sender_key": "cYzcsd0ToefoN8dUV6zCIKLOXsN7KsAR5w5Eu8Dr2Wg",
                "ciphertext": "AwgDEoAB+Pc13uMLqfgH5+dWfqJSQJ5GtA881ce2nD2CeujNgcPxty5/ph2cww6SNWtXX38Sei2y8r3KR1mWwdPWtZ1ktA+UZoyV38BA5qpC+g2OiB8KIDJhCtSjhHzAxe26t02AnPa1NdfA5uNLwFQfKLsZcjVGdEbdoXlL2+yPeFJgXVEgddRzAq45XupAER2Zd8LMeIAswYmnRxR8dBIpOmhynU3ZYU0GIXxKZN9vdydbAxldC9yf8CslqocqFFIY/M8lI3jt8O9sZgQ",
                "session_id": "p9biILBNuRe7ZzVQoqs6SCG9SNG6oGJvibPuGN6RwoQ",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "XMFKMSTCSC"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490923150788,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$149092315013lHajl:inferiorlattice.com",
              "unsigned": {
                "age": 661566942
              },
              "content": {
                "sender_key": "49zBXyYPOlHgx8a7KbpuQQHoTAQ0XJAPQ312RO+f9Uo",
                "ciphertext": "AwgCEqABKcy1pDvv8FDNV6oWTYKPCcpoBzHy48dEZz/v0u2aR7/MvWpnY3240jCPnCH6rEEuhh/ApnYBAdk+tpgUD+wWBASz44NWa3GEXDsQ9/AiB93mj1pVzHjyoCg7aS7EftaszMnbMObsH9UnHcsn3oVpVjxSr9+vyp53MIUtY+6XVtAbtgoo4ScyaGAahHptnFN8O+c2DtLo7M1nwTfP8uzGkHjAyTnDGC1k/f9tzap0bKrVhnXNQWuFaSaNwr3fyBDGAAuTv4P9N6gPuHYFSkPjM3m5QOgRjsZRWDsnZoxr5L7werT8lMKpDg",
                "session_id": "NM8gS/xwc7C40h6ESailV8GKA1x32wP2DCWYr1GA598",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "DCDSRVVHHK"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490923160118,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$149092316014NrewU:inferiorlattice.com",
              "unsigned": {
                "age": 661557612
              },
              "content": {
                "sender_key": "49zBXyYPOlHgx8a7KbpuQQHoTAQ0XJAPQ312RO+f9Uo",
                "ciphertext": "AwgDEpABw9SdfyR/3Kel5VTLc9khDUzlx8Iq409eT3375tVA1fXez/48GIVrtczWjgUAq+7UyZW11dTBkLG6FjlmTC6OqZB5dOl18GHZFs7ugkEMq78teAP1doMXh9KTvtiUCNdmcgE5w/AMWx7M2ALZFc04dehHIppiVntvQMTy0PGtu50HZURb11PQBBHR8E4qI5bI4/36nMV+STLOemkJw4+80enWd8dvud3i95HtfPF30eE3wu/CVi50CBZGOWbzxklefUg2WK4UM4qA2BLeuLK7AvmtmR9NsBwA",
                "session_id": "NM8gS/xwc7C40h6ESailV8GKA1x32wP2DCWYr1GA598",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "DCDSRVVHHK"
              },
              "type": "m.room.encrypted"
            },
            {
              "origin_server_ts": 1490923175501,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14909231750PBDQo:inferiorlattice.com",
              "unsigned": {
                "age": 661542229
              },
              "content": {
                "sender_key": "cYzcsd0ToefoN8dUV6zCIKLOXsN7KsAR5w5Eu8Dr2Wg",
                "ciphertext": "AwgEErAB/dZ7Y8DSs9jLovCmXAOVj5EwSk/ameY9QTnMPS6EToxVzS1LEvC5o7bDLHTCeF/HmoTjxoshyRPZ0FMoKHKSUDwXiJKr0KbLEu7Fq8zNyxKvvGW3xfz012mEuBmusJrfp8FwNLvVvw1No2E+k0eHXyAAzZ3OkQBq6iEoulCx3ybGSRFrBsshg/eV4DbKnOda6qeGTViCFKPmwb9wHdWtgo6jb/5xcTfC52eFndSm0WWWmANHvpfqGNvnkVRnHPvp2MTCdGu75C2nzIIx7Ax51RDgsbppEK4tG7fBpxGj1mXTyB6OLcq28ACN7/OmOadqfjofQIm9DwU",
                "session_id": "p9biILBNuRe7ZzVQoqs6SCG9SNG6oGJvibPuGN6RwoQ",
                "algorithm": "m.megolm.v1.aes-sha2",
                "device_id": "XMFKMSTCSC"
              },
              "type": "m.room.encrypted"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488492890972,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492890322ImnHc:inferiorlattice.com",
              "unsigned": {
                "age": 3091826758
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488946280847,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14889462801163adOLh:inferiorlattice.com",
              "unsigned": {
                "age": 2638436883
              },
              "state_key": "",
              "content": {
                "algorithm": "m.megolm.v1.aes-sha2"
              },
              "type": "m.room.encryption"
            },
            {
              "origin_server_ts": 1488492891158,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492891324mgRDo:inferiorlattice.com",
              "unsigned": {
                "age": 3091826572
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488492890729,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492890319rHgBF:inferiorlattice.com",
              "unsigned": {
                "age": 3091827001
              },
              "state_key": "",
              "content": {
                "creator": "@Karl:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488495228686,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488495228334EvmLD:inferiorlattice.com",
              "unsigned": {
                "age": 3089489044,
                "replaces_state": "$1488492891325mFtMy:inferiorlattice.com"
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488492890864,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492890321YKKAZ:inferiorlattice.com",
              "unsigned": {
                "age": 3091826866
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@Karl:inferiorlattice.com": 100,
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488492890783,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492890320qUolp:inferiorlattice.com",
              "unsigned": {
                "age": 3091826947
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488893041584,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$148889304129bxIVF:inferiorlattice.com",
              "unsigned": {
                "age": 2691676146,
                "replaces_state": "$1488492891323HOozS:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "history_visibility": "joined"
              },
              "type": "m.room.history_visibility"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$149092316014NrewU:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1490923161019
                    }
                  }
                },
                "$14909231750PBDQo:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1490925551239
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!tRpSgFwNrhtFMQHStu:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t298-63837_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1490969061171,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14909690612rWbBx:inferiorlattice.com",
              "unsigned": {
                "age": 615656559
              },
              "content": {
                "body": "namely korok forest and the starting plateau",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490969231025,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14909692311nTAFT:inferiorlattice.com",
              "unsigned": {
                "age": 615486705
              },
              "content": {
                "body": "neato",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490969325264,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14909693250YXMcl:inferiorlattice.com",
              "unsigned": {
                "age": 615392466
              },
              "content": {
                "body": "did they fix moblin skeletons yet",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490969486205,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14909694860DQqqj:inferiorlattice.com",
              "unsigned": {
                "age": 615231525
              },
              "content": {
                "body": "nope",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490976862231,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14909768620ACOPC:inferiorlattice.com",
              "unsigned": {
                "age": 607855499
              },
              "content": {
                "body": "https://i.redd.it/kfzza146hqoy.jpg",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490981239336,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14909812391EpHff:inferiorlattice.com",
              "unsigned": {
                "age": 603478394
              },
              "content": {
                "body": "oh jesus",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490981249927,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14909812490abxAU:inferiorlattice.com",
              "unsigned": {
                "age": 603467803
              },
              "content": {
                "body": "apparently you can activate most buttons in the game with 10 apples",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491053654042,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14910536540FctMl:inferiorlattice.com",
              "unsigned": {
                "age": 531063688
              },
              "content": {
                "body": "http://i.imgur.com/oZ7Xtb9.gifv",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491420167418,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14914201670TdFWC:inferiorlattice.com",
              "unsigned": {
                "age": 164550312
              },
              "content": {
                "body": "https://www.youtube.com/watch?v=cXMlXSDwzU8",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491575018954,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14915750185RkGbh:inferiorlattice.com",
              "unsigned": {
                "age": 9698776
              },
              "content": {
                "body": "https://gfycat.com/KnobbyLiquidAmericantoad",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488429755271,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429755179SUyhy:inferiorlattice.com",
              "unsigned": {
                "age": 3154962459,
                "replaces_state": "$1488429595152ZLJKW:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488429755248,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429755178pcWXc:inferiorlattice.com",
              "unsigned": {
                "age": 3154962482
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#zelda:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488429886003,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429886190GaHPm:inferiorlattice.com",
              "unsigned": {
                "age": 3154831727
              },
              "state_key": "",
              "content": {
                "url": "mxc://inferiorlattice.com/YFIwiVfREsLNXvnoMYVIenQo"
              },
              "type": "m.room.avatar"
            },
            {
              "origin_server_ts": 1488429595526,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429595155RMiJd:inferiorlattice.com",
              "unsigned": {
                "age": 3155122204
              },
              "state_key": "",
              "content": {
                "name": "Zelda"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488429595178,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429595151iRuER:inferiorlattice.com",
              "unsigned": {
                "age": 3155122552
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488429755217,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429755177RkVVR:inferiorlattice.com",
              "unsigned": {
                "age": 3154962513,
                "replaces_state": "$1488429595154VzmZd:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488429595049,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429595149vsaYE:inferiorlattice.com",
              "unsigned": {
                "age": 3155122681
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1489550849704,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14895508494233XOcBJ:inferiorlattice.com",
              "unsigned": {
                "age": 2033868026,
                "replaces_state": "$14895507624230EafFL:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "topic": "I love going on message boards and complaining about games I've never played!"
              },
              "type": "m.room.topic"
            },
            {
              "origin_server_ts": 1489884540890,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$14898845405425orvyB:inferiorlattice.com",
              "unsigned": {
                "age": 1700176840,
                "replaces_state": "$1488487423247uQOCX:inferiorlattice.com"
              },
              "state_key": "@kbroeker:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/sIJzUDaesErqbNrXkxDShYSk",
                "displayname": "kayla"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488492082185,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492082305jkPwe:inferiorlattice.com",
              "unsigned": {
                "age": 3092635545
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488429595114,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429595150biiTD:inferiorlattice.com",
              "unsigned": {
                "age": 3155122616
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488429595355,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488429595153FkICL:inferiorlattice.com",
              "unsigned": {
                "age": 3155122375
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488875611912,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$148887561112uVFdG:inferiorlattice.com",
              "unsigned": {
                "age": 2709105818,
                "replaces_state": "$1488561848564qwwKx:inferiorlattice.com"
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14909768620ACOPC:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1490976897433
                    }
                  }
                },
                "$14914201670TdFWC:inferiorlattice.com": {
                  "m.read": {
                    "@kbroeker:inferiorlattice.com": {
                      "ts": 1491421918727
                    }
                  }
                },
                "$14915750185RkGbh:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1491575064833
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1491576096294
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": [
            {
              "content": {
                "primary_color": "#76cfa6",
                "secondary_color": "#eaf5f0"
              },
              "type": "org.matrix.room.color_scheme"
            }
          ]
        }
      },
      "!LKWHQgqxrJTlSYMjkb:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t164-59897_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1490391320605,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14903913208395AjLCx:inferiorlattice.com",
              "unsigned": {
                "age": 1193397125
              },
              "content": {
                "body": "and then let the party have like 6 slots",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490391333872,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14903913338396Zjbem:inferiorlattice.com",
              "unsigned": {
                "age": 1193383858
              },
              "content": {
                "body": "so you can pick whichever letters you want",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490391341149,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14903913418397XcUyb:inferiorlattice.com",
              "unsigned": {
                "age": 1193376581
              },
              "content": {
                "body": "'FUCK'",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490391342822,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14903913428398TVDpE:inferiorlattice.com",
              "unsigned": {
                "age": 1193374908
              },
              "content": {
                "body": "every raid",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490391345639,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14903913458399pCgTC:inferiorlattice.com",
              "unsigned": {
                "age": 1193372091
              },
              "content": {
                "body": "indeed",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490400299696,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14904002998474CGEmm:inferiorlattice.com",
              "unsigned": {
                "age": 1184418034
              },
              "content": {
                "body": "84 more days",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491066660495,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14910666600fgVKx:inferiorlattice.com",
              "unsigned": {
                "age": 518057235
              },
              "content": {
                "body": "https://www.fflogs.com/reports/dpfBPhgv24JcCFDQ/#fight=11&type=summary",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491066791471,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14910667910GlJyR:inferiorlattice.com",
              "unsigned": {
                "age": 517926259
              },
              "content": {
                "body": "a12s cleared with literally the worst comp you can put together",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491066793347,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14910667931CanMM:inferiorlattice.com",
              "unsigned": {
                "age": 517924383
              },
              "content": {
                "body": "it's all over now",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491070702204,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$14910707020PWDjZ:inferiorlattice.com",
              "unsigned": {
                "age": 514015526
              },
              "content": {
                "body": "Went in expecting two PLD and two WHM. Did not disappoint. ",
                "msgtype": "m.text",
                "formatted_body": "Went in expecting two PLD and two WHM. Did not disappoint.",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488432190825,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432190248xUWYC:inferiorlattice.com",
              "unsigned": {
                "age": 3152526905,
                "replaces_state": "$1488432165243QtIXR:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488432190744,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432190247XFvbj:inferiorlattice.com",
              "unsigned": {
                "age": 3152526986
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#ffxiv:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1488439639451,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488439639209fQVsX:inferiorlattice.com",
              "unsigned": {
                "age": 3145078279
              },
              "state_key": "",
              "content": {
                "url": "mxc://inferiorlattice.com/MxeTBZFqeFxQMUgvjfXSAeJf"
              },
              "type": "m.room.avatar"
            },
            {
              "origin_server_ts": 1488492050719,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492050303GLonF:inferiorlattice.com",
              "unsigned": {
                "age": 3092667011
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488432165454,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432165246sGKFL:inferiorlattice.com",
              "unsigned": {
                "age": 3152552276
              },
              "state_key": "",
              "content": {
                "name": "FFXIV"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488434964521,
              "sender": "@NotReallyCanada:inferiorlattice.com",
              "event_id": "$148843496416pcIDY:inferiorlattice.com",
              "unsigned": {
                "age": 3149753209
              },
              "state_key": "@NotReallyCanada:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/WJTwzJRxVkibReZwcftENzvX",
                "displayname": "NotReallyCanada"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488432165281,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432165244QBCFY:inferiorlattice.com",
              "unsigned": {
                "age": 3152552449
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488432190900,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432190249mztIr:inferiorlattice.com",
              "unsigned": {
                "age": 3152526830,
                "replaces_state": "$1488432165245pxPdZ:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488432164987,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432164240JKcvk:inferiorlattice.com",
              "unsigned": {
                "age": 3152552743
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488432165044,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432165241njczd:inferiorlattice.com",
              "unsigned": {
                "age": 3152552686
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489884540704,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$14898845405424GasJT:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "join",
                  "avatar_url": null,
                  "displayname": "kayla"
                },
                "prev_sender": "@kbroeker:inferiorlattice.com",
                "replaces_state": "$1488487405246yUyAq:inferiorlattice.com",
                "age": 1700177026
              },
              "state_key": "@kbroeker:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/sIJzUDaesErqbNrXkxDShYSk",
                "displayname": "kayla"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488439272567,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$1488439272185zMmpV:inferiorlattice.com",
              "unsigned": {
                "age": 3145445163,
                "replaces_state": "$1488439156162WQcMQ:inferiorlattice.com",
                "invite_room_state": [
                  {
                    "content": {
                      "name": "FFXIV"
                    },
                    "type": "m.room.name",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "membership": "join",
                      "avatar_url": null,
                      "displayname": "tom"
                    },
                    "type": "m.room.member",
                    "sender": "@tom:inferiorlattice.com",
                    "state_key": "@tom:inferiorlattice.com"
                  },
                  {
                    "content": {
                      "join_rule": "public"
                    },
                    "type": "m.room.join_rules",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  }
                ]
              },
              "state_key": "@fs_IUxLV0hRZ3F4ckpUbFNZTWprYjppbmZlcmlvcmxhdHRpY2UuY29t:matrix.org",
              "content": {
                "membership": "invite",
                "avatar_url": null,
                "displayname": "VoIP Conference"
              },
              "membership": "invite",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488875611347,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14888756118UfpMM:inferiorlattice.com",
              "unsigned": {
                "age": 2709106383,
                "replaces_state": "$148843508523LVnBX:inferiorlattice.com"
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488432165119,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488432165242jqBLp:inferiorlattice.com",
              "unsigned": {
                "age": 3152552611
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14910667931CanMM:inferiorlattice.com": {
                  "m.read": {
                    "@NotReallyCanada:inferiorlattice.com": {
                      "ts": 1491070656384
                    }
                  }
                },
                "$14910707020PWDjZ:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491072009849
                    },
                    "@preston:inferiorlattice.com": {
                      "ts": 1491072568609
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1491074938159
                    },
                    "@kbroeker:inferiorlattice.com": {
                      "ts": 1491092867548
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!BltMxhwRPJhFJmtUVL:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t118-58989_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1490227122084,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14902271227877tkSXd:inferiorlattice.com",
              "unsigned": {
                "age": 1357595646
              },
              "content": {
                "body": "and suddenly being in a room with other people was surreal",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490227134267,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14902271347878aaKkG:inferiorlattice.com",
              "unsigned": {
                "age": 1357583463
              },
              "content": {
                "body": "(I say it here because there's a VR room for D&D)",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1490227640913,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14902276407879IUWkF:inferiorlattice.com",
              "unsigned": {
                "age": 1357076817
              },
              "content": {
                "body": "Just studio life",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491225939101,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14912259390WzsRz:inferiorlattice.com",
              "unsigned": {
                "age": 358778629
              },
              "content": {
                "body": "So I'm Thinking About Killing My DM\nhttps://www.reddit.com/r/DnD/comments/6344u0/so_im_thinking_about_killing_my_dm/",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491225956905,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14912259561rCleQ:inferiorlattice.com",
              "unsigned": {
                "age": 358760825
              },
              "content": {
                "body": "We should dnd at some point",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491226266253,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14912262660dHCvv:inferiorlattice.com",
              "unsigned": {
                "age": 358451477
              },
              "content": {
                "body": "Ba dun dun dun dun dananana",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491226290636,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14912262900mzWQB:inferiorlattice.com",
              "unsigned": {
                "age": 358427094
              },
              "content": {
                "body": "That we should",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491228961219,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14912289611UywCl:inferiorlattice.com",
              "unsigned": {
                "age": 355756511
              },
              "content": {
                "body": "after this week work should quiet down",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491494095676,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14914940952EwxTB:inferiorlattice.com",
              "unsigned": {
                "age": 90622054
              },
              "content": {
                "body": "I like to think of [D&D arcane magic classes] in terms of university admission. The wizard is the guy who hit the books, studied hard, and got in on his own merits, the sorcerer got in because his parents are wealthy alumni, the warlock blew the dean.",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491494194838,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14914941940jdVxI:inferiorlattice.com",
              "unsigned": {
                "age": 90522892
              },
              "content": {
                "body": "lol",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488487686685,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487686273lPFJT:inferiorlattice.com",
              "unsigned": {
                "age": 3097031045,
                "replaces_state": "$1488487614261NotdQ:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488487810479,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487810280BlkvC:inferiorlattice.com",
              "unsigned": {
                "age": 3096907251
              },
              "state_key": "inferiorlattice.com",
              "content": {
                "aliases": [
                  "#dnd:inferiorlattice.com"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1489884980669,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$14898849805429KifBU:inferiorlattice.com",
              "unsigned": {
                "age": 1699737061,
                "replaces_state": "$14898849045428aPvJE:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "url": "mxc://inferiorlattice.com/fceLzsUzPdDFlZimGBEJiRcg"
              },
              "type": "m.room.avatar"
            },
            {
              "origin_server_ts": 1488487615104,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487615264TIHDo:inferiorlattice.com",
              "unsigned": {
                "age": 3097102626
              },
              "state_key": "",
              "content": {
                "name": "DND"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1488487686649,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487686272VjiKn:inferiorlattice.com",
              "unsigned": {
                "age": 3097031081,
                "replaces_state": "$1488487615263lMaey:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "guest_access": "forbidden"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488487614944,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487614262JxrsQ:inferiorlattice.com",
              "unsigned": {
                "age": 3097102786
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1488487614631,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487614258NFuSf:inferiorlattice.com",
              "unsigned": {
                "age": 3097103099
              },
              "state_key": "",
              "content": {
                "creator": "@kbroeker:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488758471435,
              "sender": "@arcarr:inferiorlattice.com",
              "event_id": "$1488758471698SDnPC:inferiorlattice.com",
              "unsigned": {
                "age": 2826246295
              },
              "state_key": "@arcarr:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "Alexis"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488487825930,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487825282sMDMO:inferiorlattice.com",
              "unsigned": {
                "age": 3096891800
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489884541050,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$14898845415426Zwtxq:inferiorlattice.com",
              "unsigned": {
                "age": 1700176680,
                "replaces_state": "$1488487614259ZjLeY:inferiorlattice.com"
              },
              "state_key": "@kbroeker:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/sIJzUDaesErqbNrXkxDShYSk",
                "displayname": "kayla"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488492066016,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$1488492066304XBmaU:inferiorlattice.com",
              "unsigned": {
                "age": 3092651714
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488875612313,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$148887561213LHpfr:inferiorlattice.com",
              "unsigned": {
                "age": 2709105417,
                "replaces_state": "$1488569017575zJpka:inferiorlattice.com"
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488487955013,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487955289ccIRP:inferiorlattice.com",
              "unsigned": {
                "age": 3096762717,
                "replaces_state": "$1488487614260OEjqu:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100,
                  "@kbroeker:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14914940952EwxTB:inferiorlattice.com": {
                  "m.read": {
                    "@tom:inferiorlattice.com": {
                      "ts": 1491494179450
                    }
                  }
                },
                "$14914941940jdVxI:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491494476833
                    },
                    "@arcarr:inferiorlattice.com": {
                      "ts": 1491535944879
                    },
                    "@preston:inferiorlattice.com": {
                      "ts": 1491494460136
                    }
                  }
                },
                "$14912289611UywCl:inferiorlattice.com": {
                  "m.read": {
                    "@kbroeker:inferiorlattice.com": {
                      "ts": 1491231142672
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!NvNzoExKIggXPmVyCU:matrix.org": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t195-67985_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1491367621941,
              "sender": "@thecm:matrix.org",
              "event_id": "$1491367621538683tnfRO:matrix.org",
              "unsigned": {
                "age": 217095789
              },
              "state_key": "@thecm:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/NeishGbbJigQwAPUEaCiSHja",
                "displayname": "thecm"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491368850336,
              "sender": "@robswain:matrix.org",
              "event_id": "$1491368850547524jMCYj:matrix.org",
              "unsigned": {
                "age": 215867394
              },
              "content": {
                "body": "Matthew: we got a comment from ngokevin too :)",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491379690453,
              "sender": "@nouts:matrix.org",
              "event_id": "$1491379690625567pnQYt:matrix.org",
              "unsigned": {
                "age": 205027277
              },
              "state_key": "@nouts:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/lIoOYiVOfUizpwAwdmlfNEJo",
                "displayname": "Nouts"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491380624038,
              "sender": "@rxl881:matrix.org",
              "event_id": "$1491380624632702WRWTw:matrix.org",
              "unsigned": {
                "age": 204093692
              },
              "content": {
                "body": "great :)",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491382582253,
              "sender": "@198646:matrix.org",
              "event_id": "$1491382582648048zEgwC:matrix.org",
              "unsigned": {
                "age": 202135477
              },
              "state_key": "@198646:matrix.org",
              "content": {
                "kind": "guest",
                "avatar_url": null,
                "displayname": "Guest 198646",
                "membership": "join"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491383862669,
              "sender": "@rxl881:matrix.org",
              "event_id": "$1491383862658698oNzRQ:matrix.org",
              "unsigned": {
                "age": 200855061
              },
              "content": {
                "body": "zottel, vurpo - I have updated the WebVR warning to hopefully make it more obvious that it is just an advisory (for people trying to use a VR headset)",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491384794242,
              "sender": "@198683:matrix.org",
              "event_id": "$1491384794665924hAHWi:matrix.org",
              "unsigned": {
                "age": 199923488
              },
              "state_key": "@198683:matrix.org",
              "content": {
                "kind": "guest",
                "avatar_url": null,
                "displayname": "Danmaz74",
                "membership": "join"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491387025753,
              "sender": "@zottel:matrix.zottel.net",
              "event_id": "$1491387025960bbJRe:matrix.zottel.net",
              "unsigned": {
                "age": 197691977
              },
              "content": {
                "body": "Nice, thanks",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491387637096,
              "sender": "@bobchao:matrix.org",
              "event_id": "$14913876371815UdPER:matrix.org",
              "unsigned": {
                "age": 197080634
              },
              "state_key": "@bobchao:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "bobchao"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491389375943,
              "sender": "@bobchao:matrix.org",
              "event_id": "$149138937516984IIHDW:matrix.org",
              "unsigned": {
                "prev_content": {
                  "membership": "join",
                  "avatar_url": null,
                  "displayname": "bobchao"
                },
                "prev_sender": "@bobchao:matrix.org",
                "replaces_state": "$14913876371815UdPER:matrix.org",
                "age": 195341787
              },
              "state_key": "@bobchao:matrix.org",
              "content": {
                "membership": "leave"
              },
              "membership": "leave",
              "type": "m.room.member"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1491315142690,
              "sender": "@vurpo:vurpo.fi",
              "event_id": "$149131514238VyGsc:vurpo.fi",
              "unsigned": {
                "age": 6
              },
              "state_key": "@vurpo:vurpo.fi",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://vurpo.fi/rAVYYdwTozdZslBFduliksPR",
                "displayname": "vurpo"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491316561881,
              "sender": "@rxl881:matrix.org",
              "event_id": "$1491316561180379OiOgC:matrix.org",
              "unsigned": {
                "age": 4969006
              },
              "state_key": "@rxl881:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/izrAwSPCQqkFrcCaPAjAogqc",
                "displayname": "Rick"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491346101572,
              "sender": "@198356:matrix.org",
              "event_id": "$1491346101351207YaRJO:matrix.org",
              "unsigned": {
                "age": 238616158
              },
              "state_key": "@198356:matrix.org",
              "content": {
                "kind": "guest",
                "avatar_url": null,
                "displayname": "soeatthemeek",
                "membership": "join"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491329719606,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913297193RRXnt:inferiorlattice.com",
              "unsigned": {
                "age": 254998124
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491316994779,
              "sender": "@matthew:matrix.org",
              "event_id": "$1491316994185642CCHUq:matrix.org",
              "unsigned": {
                "age": 4536108
              },
              "state_key": "",
              "content": {
                "alias": "#vr:matrix.org"
              },
              "type": "m.room.canonical_alias"
            },
            {
              "origin_server_ts": 1491321530712,
              "sender": "@tom:inferiorlattice.com",
              "event_id": "$14913215781EKgcZ:inferiorlattice.com",
              "unsigned": {
                "age": 263139390
              },
              "state_key": "@tom:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/hbZwdxsXZMSDgIekqaGhHgaW",
                "displayname": "tom"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491262746444,
              "sender": "@Amandine:matrix.org",
              "event_id": "$14912627462545442IGZyp:matrix.org",
              "unsigned": {
                "age": 58784443
              },
              "state_key": "@Amandine:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/gWLPZZSJPbhgHoyShiGSesXS",
                "displayname": "Amandine"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491356046802,
              "sender": "@aaron:raim.ist",
              "event_id": "$1491356046101BTWVj:raim.ist",
              "unsigned": {
                "age": 16
              },
              "state_key": "@aaron:raim.ist",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://raim.ist/FXOzjAdHBpcxFBqpKIbQWInl",
                "displayname": "Aaron Raimist"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491262709165,
              "sender": "@matthew:matrix.org",
              "event_id": "$14912627092545178JMVXY:matrix.org",
              "unsigned": {
                "age": 58821722,
                "replaces_state": "$14899170351798954GMDzD:matrix.org"
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1491314156600,
              "sender": "@matthew:matrix.org",
              "event_id": "$1491314156150500JlVPv:matrix.org",
              "unsigned": {
                "age": 7374287,
                "replaces_state": "$14912626972545101afBvx:matrix.org"
              },
              "state_key": "",
              "content": {
                "topic": "Discussion of all things Matrix + VR | https://matrix.org/vrdemo"
              },
              "type": "m.room.topic"
            },
            {
              "origin_server_ts": 1491315219745,
              "sender": "@travis:t2l.io",
              "event_id": "$14913152201219LUyTF:t2l.io",
              "unsigned": {
                "age": 13
              },
              "state_key": "@travis:t2l.io",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://t2l.io/fYhaPLjAZLwEYqaSGKwRpQgk",
                "displayname": "TravisR"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489917035760,
              "sender": "@matthew:matrix.org",
              "event_id": "$14899170351798955dVMWp:matrix.org",
              "unsigned": {
                "age": 1404495127,
                "replaces_state": "$14898963991701639dqEqe:matrix.org"
              },
              "state_key": "",
              "content": {
                "join_rule": "public"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1489896633524,
              "sender": "@matthew:matrix.org",
              "event_id": "$14898966331703027AQwJc:matrix.org",
              "unsigned": {
                "age": 1424897363
              },
              "state_key": "matrix.org",
              "content": {
                "aliases": [
                  "#vr:matrix.org"
                ]
              },
              "type": "m.room.aliases"
            },
            {
              "origin_server_ts": 1491300959737,
              "sender": "@satyrs:matrix.org",
              "event_id": "$149130095916414lEWsL:matrix.org",
              "unsigned": {
                "age": 20571150
              },
              "state_key": "@satyrs:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/klakOmraNAbnXTpjdBnicQGn",
                "displayname": "Satyr 🔞"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491314958038,
              "sender": "@voyager:t2bot.io",
              "event_id": "$1491314958231VfhZV:t2bot.io",
              "unsigned": {
                "age": 7
              },
              "state_key": "@voyager:t2bot.io",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://t2bot.io/hcSELkhLCNMRxLLTXKffPPSn",
                "displayname": "Matrix Traveler"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491313696123,
              "sender": "@SimbaLion:matrix.org",
              "event_id": "$1491313696145155jRuXy:matrix.org",
              "unsigned": {
                "age": 7834764
              },
              "state_key": "@SimbaLion:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/njQoTXCiTMrkbWFcYeNjlJyK",
                "displayname": "SimbaLion @ FWA"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489896398481,
              "sender": "@matthew:matrix.org",
              "event_id": "$14898963981701633yyRiH:matrix.org",
              "unsigned": {
                "age": 1425132406
              },
              "state_key": "",
              "content": {
                "creator": "@matthew:matrix.org"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1491299325697,
              "sender": "@max:kamax.io",
              "event_id": "$1491299324621hANDn:kamax.io",
              "unsigned": {
                "age": 6
              },
              "state_key": "@max:kamax.io",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://kamax.io/sSxwZXBUOtXYRNAucBRlByLP",
                "displayname": "Max"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491341096986,
              "sender": "@148833:matrix.org",
              "event_id": "$1491341096299587MUPBa:matrix.org",
              "unsigned": {
                "age": 243620744
              },
              "state_key": "@148833:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/DoOrcNwyloaOgWwtgxaSHOak",
                "displayname": "hl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491334440897,
              "sender": "@zottel:matrix.zottel.net",
              "event_id": "$1491334440934YXLaH:matrix.zottel.net",
              "unsigned": {
                "age": 91774
              },
              "state_key": "@zottel:matrix.zottel.net",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.zottel.net/YsrfijXnxjlBfIlStuXJRVgx",
                "displayname": "zottel"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491307505311,
              "sender": "@robswain:matrix.org",
              "event_id": "$149130750564414QGtYo:matrix.org",
              "unsigned": {
                "age": 14025576
              },
              "state_key": "@robswain:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/uQxuJwsgLGIHlBcaATaSLRpH",
                "displayname": "Rob"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491328108250,
              "sender": "@realitygaps:chat.weho.st",
              "event_id": "$149132810866656njvZL:chat.weho.st",
              "unsigned": {
                "age": 6
              },
              "state_key": "@realitygaps:chat.weho.st",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://chat.weho.st/qgGFaSnvtkdXGBotgrUuaQGR",
                "displayname": "realitygaps"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491312864684,
              "sender": "@am2on:atauno.com",
              "event_id": "$14913128644407Mjxrh:atauno.com",
              "unsigned": {
                "age": 83
              },
              "state_key": "@am2on:atauno.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://atauno.com/arTKTcpxTBsoESxJARrukaSE",
                "displayname": "am2on"
              },
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489896398696,
              "sender": "@matthew:matrix.org",
              "event_id": "$14898963981701635YLLpJ:matrix.org",
              "unsigned": {
                "age": 1425132191
              },
              "state_key": "@matthew:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/zFHVTzeUHJnsbomaeHEehfSI",
                "displayname": "Matthew"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491354114171,
              "sender": "@xuv:matrix.org",
              "event_id": "$1491354114422083UMIFb:matrix.org",
              "unsigned": {
                "age": 230603559
              },
              "state_key": "@xuv:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/viPBiAugtSPDKRuOKuGZzjNP",
                "displayname": "xuv"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491262709162,
              "sender": "@matthew:matrix.org",
              "event_id": "$14912627092545177cPdTu:matrix.org",
              "unsigned": {
                "age": 58821725,
                "replaces_state": "$14898963991701641OrXED:matrix.org"
              },
              "state_key": "",
              "content": {
                "history_visibility": "world_readable"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1491315327661,
              "sender": "@abeckmeyer:matrix.org",
              "event_id": "$1491315327165264zsOks:matrix.org",
              "unsigned": {
                "age": 6203226
              },
              "state_key": "@abeckmeyer:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/zrvwZKBzqrQlXLxyQFmptAOO",
                "displayname": "{ Adam }"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491262674944,
              "sender": "@matthew:matrix.org",
              "event_id": "$14912626742544957lKcSn:matrix.org",
              "unsigned": {
                "age": 58855943,
                "replaces_state": "$14912626452544170CaXhH:matrix.org"
              },
              "state_key": "",
              "content": {
                "url": "mxc://matrix.org/rlfWidCSHYiWCYHftAudkzsH"
              },
              "type": "m.room.avatar"
            },
            {
              "origin_server_ts": 1489896398919,
              "sender": "@matthew:matrix.org",
              "event_id": "$14898963981701638exqxD:matrix.org",
              "unsigned": {
                "age": 1425131968
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@matthew:matrix.org": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1491295094118,
              "sender": "@PureTryOut:matrix.org",
              "event_id": "$14912950942793435YdleA:matrix.org",
              "unsigned": {
                "age": 26436769
              },
              "state_key": "@PureTryOut:matrix.org",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://matrix.org/zgNxjNNzAQMuUkITcrKvmUen",
                "displayname": "PureTryOut"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491294977242,
              "sender": "@erikj:jki.re",
              "event_id": "$149129497716fPWzP:jki.re",
              "unsigned": {
                "age": 64
              },
              "state_key": "@erikj:jki.re",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://jki.re/GVSWoYAaZphVlOxPuwtQCFCl",
                "displayname": "Erik"
              },
              "type": "m.room.member"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14913215781EKgcZ:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491325468129
                    }
                  }
                },
                "$1491356046101BTWVj:raim.ist": {
                  "m.read": {
                    "@thecm:matrix.org": {
                      "ts": 1491367612269
                    }
                  }
                },
                "$1491328058136448xcpPq:matrix.org": {
                  "m.read": {
                    "@voyager:t2bot.io": {
                      "ts": 1491328059287
                    }
                  }
                },
                "$149138937516984IIHDW:matrix.org": {
                  "m.read": {
                    "@abeckmeyer:matrix.org": {
                      "ts": 1491407741697
                    },
                    "@preston:inferiorlattice.com": {
                      "ts": 1491399655163
                    },
                    "@robswain:matrix.org": {
                      "ts": 1491558344931
                    },
                    "@nouts:matrix.org": {
                      "ts": 1491420719984
                    },
                    "@matthew:matrix.org": {
                      "ts": 1491420028688
                    },
                    "@vurpo:vurpo.fi": {
                      "ts": 1491391978363
                    },
                    "@am2on:atauno.com": {
                      "ts": 1491394901336
                    },
                    "@max:kamax.io": {
                      "ts": 1491468751510
                    },
                    "@aaron:raim.ist": {
                      "ts": 1491418801095
                    },
                    "@xuv:matrix.org": {
                      "ts": 1491392928666
                    },
                    "@travis:t2l.io": {
                      "ts": 1491401995164
                    },
                    "@tom:inferiorlattice.com": {
                      "ts": 1491403533599
                    },
                    "@realitygaps:chat.weho.st": {
                      "ts": 1491418139201
                    },
                    "@satyrs:matrix.org": {
                      "ts": 1491472210427
                    }
                  }
                },
                "$14913876371815UdPER:matrix.org": {
                  "m.read": {
                    "@Amandine:matrix.org": {
                      "ts": 1491388792542
                    },
                    "@PureTryOut:matrix.org": {
                      "ts": 1491388440178
                    }
                  }
                },
                "$1491341096299587MUPBa:matrix.org": {
                  "m.read": {
                    "@148833:matrix.org": {
                      "ts": 1491341100822
                    }
                  }
                },
                "$1491380624632702WRWTw:matrix.org": {
                  "m.read": {
                    "@erikj:jki.re": {
                      "ts": 1491381757322
                    }
                  }
                },
                "$1491379690625567pnQYt:matrix.org": {
                  "m.read": {
                    "@agilob:matrix.org": {
                      "ts": 1491379710438
                    }
                  }
                },
                "$1491387025960bbJRe:matrix.zottel.net": {
                  "m.read": {
                    "@rxl881:matrix.org": {
                      "ts": 1491387161113
                    },
                    "@zottel:matrix.zottel.net": {
                      "ts": 1491387025907
                    },
                    "@bobchao:matrix.org": {
                      "ts": 1491387631380
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!JFlhFnCXmcvdPvSNdB:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t6-39529_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1488487669737,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487669270NRhwk:inferiorlattice.com",
              "unsigned": {
                "age": 3097047993
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1488487669851,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487669271xSjAi:inferiorlattice.com",
              "unsigned": {
                "age": 3097047879,
                "invite_room_state": [
                  {
                    "content": {
                      "join_rule": "invite"
                    },
                    "type": "m.room.join_rules",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": ""
                  },
                  {
                    "content": {
                      "membership": "join",
                      "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                      "displayname": "preston"
                    },
                    "type": "m.room.member",
                    "sender": "@preston:inferiorlattice.com",
                    "state_key": "@preston:inferiorlattice.com"
                  }
                ]
              },
              "state_key": "@kbroeker:inferiorlattice.com",
              "content": {
                "membership": "invite",
                "avatar_url": null,
                "displayname": "kayla",
                "is_direct": true
              },
              "membership": "invite",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488487687490,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487687274wSFGy:inferiorlattice.com",
              "unsigned": {
                "age": 3097030240
              },
              "content": {
                "body": "And private chats are a thing ofc",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488487694988,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487694275bTfsz:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "invite",
                  "avatar_url": null,
                  "displayname": "kayla",
                  "is_direct": true
                },
                "prev_sender": "@preston:inferiorlattice.com",
                "replaces_state": "$1488487669271xSjAi:inferiorlattice.com",
                "age": 3097022742
              },
              "state_key": "@kbroeker:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": null,
                "displayname": "kayla"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488487726102,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487726276dbfeM:inferiorlattice.com",
              "unsigned": {
                "age": 3096991628
              },
              "content": {
                "body": "neat.  so do I have to give the dnd room an address",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488487767352,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487767277lKpMw:inferiorlattice.com",
              "unsigned": {
                "age": 3096950378
              },
              "content": {
                "body": "Needs an address, available if you know the room, and listed",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488487774968,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487774278qQWXc:inferiorlattice.com",
              "unsigned": {
                "age": 3096942762
              },
              "content": {
                "body": "To get it to show up",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488487807460,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487807279yVhqG:inferiorlattice.com",
              "unsigned": {
                "age": 3096910270
              },
              "content": {
                "body": "So like #dnd:inferiorlattice.com would work",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1488487823226,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$1488487823281apISL:inferiorlattice.com",
              "unsigned": {
                "age": 3096894504
              },
              "content": {
                "body": "I think I did it",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1489884541224,
              "sender": "@kbroeker:inferiorlattice.com",
              "event_id": "$14898845415427SQuYf:inferiorlattice.com",
              "unsigned": {
                "prev_content": {
                  "membership": "join",
                  "avatar_url": null,
                  "displayname": "kayla"
                },
                "prev_sender": "@kbroeker:inferiorlattice.com",
                "replaces_state": "$1488487694275bTfsz:inferiorlattice.com",
                "age": 1700176506
              },
              "state_key": "@kbroeker:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/sIJzUDaesErqbNrXkxDShYSk",
                "displayname": "kayla"
              },
              "membership": "join",
              "type": "m.room.member"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1488487669339,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487669265yISRG:inferiorlattice.com",
              "unsigned": {
                "age": 3097048391
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1488487669560,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487669268SPQxq:inferiorlattice.com",
              "unsigned": {
                "age": 3097048170
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1488487669389,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487669266YRxWx:inferiorlattice.com",
              "unsigned": {
                "age": 3097048341
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1488487669466,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487669267crjEz:inferiorlattice.com",
              "unsigned": {
                "age": 3097048264
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100,
                  "@kbroeker:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1488487669642,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$1488487669269LXHXd:inferiorlattice.com",
              "unsigned": {
                "age": 3097048088
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$1488487807279yVhqG:inferiorlattice.com": {
                  "m.read": {
                    "@kbroeker:inferiorlattice.com": {
                      "ts": 1488487813597
                    }
                  }
                },
                "$14898845415427SQuYf:inferiorlattice.com": {
                  "m.read": {
                    "@preston:inferiorlattice.com": {
                      "ts": 1490763332289
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": []
        }
      },
      "!KEahhDjtfCAfIkmOXb:inferiorlattice.com": {
        "unread_notifications": {},
        "timeline": {
          "limited": false,
          "prev_batch": "s70358_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1491332695326,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913326950PSpte:inferiorlattice.com",
              "unsigned": {
                "age": 252022404
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1491332695391,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913326951IhfyO:inferiorlattice.com",
              "unsigned": {
                "age": 252022339
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1491332695460,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913326952mzXHv:inferiorlattice.com",
              "unsigned": {
                "age": 252022270
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1491332695536,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913326953wWhEc:inferiorlattice.com",
              "unsigned": {
                "age": 252022194
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1491332695632,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913326954Nfqbv:inferiorlattice.com",
              "unsigned": {
                "age": 252022098
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            },
            {
              "origin_server_ts": 1491332695729,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913326955shTyh:inferiorlattice.com",
              "unsigned": {
                "age": 252022001
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1491332695800,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913326956agEHM:inferiorlattice.com",
              "unsigned": {
                "age": 252021930
              },
              "state_key": "",
              "content": {
                "name": "prestontest"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1491332705313,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913327057QqHGO:inferiorlattice.com",
              "unsigned": {
                "age": 252012417
              },
              "content": {
                "body": "<sup>boom</sup>",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491332718488,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14913327188bFGVJ:inferiorlattice.com",
              "unsigned": {
                "age": 251999242
              },
              "content": {
                "body": "<sub>boom</sub>",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": []
        },
        "ephemeral": {
          "events": []
        },
        "account_data": {
          "events": []
        }
      },
      "!yGVzexedGluSpUyeQK:inferiorlattice.com": {
        "unread_notifications": {
          "highlight_count": 0,
          "notification_count": 0
        },
        "timeline": {
          "limited": true,
          "prev_batch": "t4164-70234_1489512_0_56039_103_110_105_5935",
          "events": [
            {
              "origin_server_ts": 1491579001320,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915790011HrOgA:inferiorlattice.com",
              "unsigned": {
                "age": 5716410
              },
              "content": {
                "body": "They're not yet",
                "msgtype": "m.text",
                "formatted_body": "They&#39;re not yet",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579018547,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915790182AdSit:inferiorlattice.com",
              "unsigned": {
                "age": 5699183
              },
              "content": {
                "body": "Yeah, theyre pretty busy",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579051058,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915790513jCwtT:inferiorlattice.com",
              "unsigned": {
                "age": 5666672
              },
              "content": {
                "body": "I figured I'm riding the Karl to work train until they take a look at it",
                "msgtype": "m.text",
                "formatted_body": "I figured I&#39;m riding the Karl to work train until they take a look at it",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579101182,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14915791010qzJzz:inferiorlattice.com",
              "unsigned": {
                "age": 5616548
              },
              "content": {
                "body": "like you're coming in after lunch ?",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579111938,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915791111KKbkf:inferiorlattice.com",
              "unsigned": {
                "age": 5605792
              },
              "content": {
                "body": "Nah, next week",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579118914,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14915791182BTMoi:inferiorlattice.com",
              "unsigned": {
                "age": 5598816
              },
              "content": {
                "body": "oh i see",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579120426,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915791203gMVom:inferiorlattice.com",
              "unsigned": {
                "age": 5597304
              },
              "content": {
                "body": "If it takes that long",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579962758,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14915799622Ukish:inferiorlattice.com",
              "unsigned": {
                "age": 4754972
              },
              "content": {
                "body": "ok, heading your way",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491579968984,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915799684mWeMq:inferiorlattice.com",
              "unsigned": {
                "age": 4748746
              },
              "content": {
                "body": "Kewl",
                "msgtype": "m.text"
              },
              "type": "m.room.message"
            },
            {
              "origin_server_ts": 1491580795361,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14915807950wdGgJ:inferiorlattice.com",
              "unsigned": {
                "age": 3922369
              },
              "content": {
                "body": "Just let me know when you're close/here",
                "msgtype": "m.text",
                "formatted_body": "Just let me know when you&#39;re close/here",
                "format": "org.matrix.custom.html"
              },
              "type": "m.room.message"
            }
          ]
        },
        "state": {
          "events": [
            {
              "origin_server_ts": 1489012826652,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14890128261854tvfmp:inferiorlattice.com",
              "unsigned": {
                "age": 2571891078
              },
              "state_key": "",
              "content": {
                "join_rule": "invite"
              },
              "type": "m.room.join_rules"
            },
            {
              "origin_server_ts": 1489066187666,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14890661871930aKFZS:inferiorlattice.com",
              "unsigned": {
                "age": 2518530064,
                "replaces_state": "$14890661271926kCARC:inferiorlattice.com"
              },
              "state_key": "",
              "content": {
                "name": "Fra-ber Unencrypted"
              },
              "type": "m.room.name"
            },
            {
              "origin_server_ts": 1489012826835,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14890128261856QXqdi:inferiorlattice.com",
              "unsigned": {
                "age": 2571890895
              },
              "state_key": "",
              "content": {
                "guest_access": "can_join"
              },
              "type": "m.room.guest_access"
            },
            {
              "origin_server_ts": 1489012826374,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14890128261851ZXqYR:inferiorlattice.com",
              "unsigned": {
                "age": 2571891356
              },
              "state_key": "",
              "content": {
                "creator": "@preston:inferiorlattice.com"
              },
              "type": "m.room.create"
            },
            {
              "origin_server_ts": 1489012826431,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14890128261852jGbGN:inferiorlattice.com",
              "unsigned": {
                "age": 2571891299
              },
              "state_key": "@preston:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/MVKNQzhnQcUuTNuzCiMwykIS",
                "displayname": "preston"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489012826516,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14890128261853qkZKM:inferiorlattice.com",
              "unsigned": {
                "age": 2571891214
              },
              "state_key": "",
              "content": {
                "events_default": 0,
                "invite": 0,
                "state_default": 50,
                "redact": 50,
                "ban": 50,
                "users_default": 0,
                "events": {
                  "m.room.avatar": 50,
                  "m.room.name": 50,
                  "m.room.canonical_alias": 50,
                  "m.room.history_visibility": 100,
                  "m.room.power_levels": 100
                },
                "kick": 50,
                "users": {
                  "@Karl:inferiorlattice.com": 100,
                  "@preston:inferiorlattice.com": 100
                }
              },
              "type": "m.room.power_levels"
            },
            {
              "origin_server_ts": 1489012961545,
              "sender": "@Karl:inferiorlattice.com",
              "event_id": "$14890129611858FUzbx:inferiorlattice.com",
              "unsigned": {
                "age": 2571756185,
                "replaces_state": "$14890128261857gqjyN:inferiorlattice.com"
              },
              "state_key": "@Karl:inferiorlattice.com",
              "content": {
                "membership": "join",
                "avatar_url": "mxc://inferiorlattice.com/ZCuRAVGAmLglpHfWRDErsPOS",
                "displayname": "Karl"
              },
              "membership": "join",
              "type": "m.room.member"
            },
            {
              "origin_server_ts": 1489012826749,
              "sender": "@preston:inferiorlattice.com",
              "event_id": "$14890128261855Ytmkl:inferiorlattice.com",
              "unsigned": {
                "age": 2571890981
              },
              "state_key": "",
              "content": {
                "history_visibility": "shared"
              },
              "type": "m.room.history_visibility"
            }
          ]
        },
        "ephemeral": {
          "events": [
            {
              "content": {
                "$14915807950wdGgJ:inferiorlattice.com": {
                  "m.read": {
                    "@Karl:inferiorlattice.com": {
                      "ts": 1491581997297
                    },
                    "@preston:inferiorlattice.com": {
                      "ts": 1491580795544
                    }
                  }
                }
              },
              "type": "m.receipt"
            }
          ]
        },
        "account_data": {
          "events": [
            {
              "content": {
                "tags": {
                  "m.favourite": {
                    "order": 0.75
                  }
                }
              },
              "type": "m.tag"
            }
          ]
        }
      }
    },
    "invite": {}
  },
  "device_lists": {
    "changed": []
  }
}
# PokemonGo-Desktop
An unofficial desktop version of the mobile game using unity. Designed to be close to the original game however slightly modified to allow better desktop support, such as WASD movement.
This is not designed to be a cheating tool! It is meant to allow user who are unable to play the mobile version of the game, for whatever reason, to not be left out. 

##Target platforms
Using unity allows the project to be exported to numerous devices, however some devices require extra consideration when designing support them, so a select few platforms are being mainly focused upon.
- Windows
- Linux
- Web (Using WebGL)

##Features
- [x] PTC Login
- [ ] Google Login
- [ ] Registration
- [ ] Map (Using Google Maps for images)
- [ ] Nearby Pokemon
- [ ] WASD Support
- [ ] Map (with teleport and viewing past local area, can be disabled if you think it's cheating)
- [ ] All Pokemons
- [ ] Pokemon Catching 
- [ ] Pokestops
- [ ] Gyms
- [ ] Teams
- [ ] Journal
- [ ] Medals

Teleporting is left enabled incase you end up somewhere crazy via a bug, like the middle of the ocean. It will be disabled by default. 

##Isn't this still cheating?

As some people have pointed out, this project is still cheating as it is allowing people to be able to do stuff that can't otherwise. The intention is to allow more people to play the game. I won't be adding any "boting" features such as auto catchers and auto pokemon returners. There are also a dozen GPS spoofing tools already out there that work with your phone and are easier to use, people who want to just cheat in this way are more likely to use one of those tools anyway. This program is not allowing something that already isn't possible.

##Why not uss a android emulator/etc?

You probably should use one of those instead of this project if you want the latest features and want a non-buggy experience. This project is mainly for fun.

##Developers 
Anyone is more than welcome to submit a pull requests! Just follow these guidelines
- Keep the code tidy
- Make sure give credit where due
- Use as many of the unity built in features for better cross platform support
- Make any features that could be classed as cheating, able to be disabled in the settings
- State all changes clearly in changes and pull requests
- Test the changes thoroughly first

##Contact
Slack: https://error22.herokuapp.com/ (#pokemongo-desktop channel)

Email: chandler2newman@hotmail.co.uk

##Special Thanks
- https://github.com/eamonwoortman/RestSharp.Unity (Rest networking library ported to unity)
- https://github.com/AeonLucid/POGOProtos (All of the networking messages)
- https://github.com/bitcraftCoLtd/protobuf3-for-unity (Allows those messages to be used in unity)

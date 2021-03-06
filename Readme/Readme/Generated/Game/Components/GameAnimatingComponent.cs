﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameContext {

    public GameEntity animatingEntity { get { return GetGroup(GameMatcher.Animating).GetSingleEntity(); } }

    public bool isAnimating {
        get { return animatingEntity != null; }
        set {
            var entity = animatingEntity;
            if(value != (entity != null)) {
                if(value) {
                    CreateEntity().isAnimating = true;
                } else {
                    DestroyEntity(entity);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly AnimatingComponent animatingComponent = new AnimatingComponent();

    public bool isAnimating {
        get { return HasComponent(GameComponentsLookup.Animating); }
        set {
            if(value != isAnimating) {
                if(value) {
                    AddComponent(GameComponentsLookup.Animating, animatingComponent);
                } else {
                    RemoveComponent(GameComponentsLookup.Animating);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAnimating;

    public static Entitas.IMatcher<GameEntity> Animating {
        get {
            if(_matcherAnimating == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Animating);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAnimating = matcher;
            }

            return _matcherAnimating;
        }
    }
}

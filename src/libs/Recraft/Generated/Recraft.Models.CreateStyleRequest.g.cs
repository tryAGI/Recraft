#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateStyleRequest : global::System.IEquatable<CreateStyleRequest>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.CreateStyleRequestBase? Base { get; init; }
#else
        public global::Recraft.CreateStyleRequestBase? Base { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base))]
#endif
        public bool IsBase => Base != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickBase(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.CreateStyleRequestBase? value)
        {
            value = Base;
            return IsBase;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.CreateStyleRequestBase PickBase() => IsBase
            ? Base!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.CreateStyleRequestVariant2? CreateStyleRequestVariant2 { get; init; }
#else
        public global::Recraft.CreateStyleRequestVariant2? CreateStyleRequestVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateStyleRequestVariant2))]
#endif
        public bool IsCreateStyleRequestVariant2 => CreateStyleRequestVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCreateStyleRequestVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.CreateStyleRequestVariant2? value)
        {
            value = CreateStyleRequestVariant2;
            return IsCreateStyleRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.CreateStyleRequestVariant2 PickCreateStyleRequestVariant2() => IsCreateStyleRequestVariant2
            ? CreateStyleRequestVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateStyleRequestVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStyleRequest(global::Recraft.CreateStyleRequestBase value) => new CreateStyleRequest((global::Recraft.CreateStyleRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.CreateStyleRequestBase?(CreateStyleRequest @this) => @this.Base;

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleRequest(global::Recraft.CreateStyleRequestBase? value)
        {
            Base = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateStyleRequest FromBase(global::Recraft.CreateStyleRequestBase? value) => new CreateStyleRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateStyleRequest(global::Recraft.CreateStyleRequestVariant2 value) => new CreateStyleRequest((global::Recraft.CreateStyleRequestVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.CreateStyleRequestVariant2?(CreateStyleRequest @this) => @this.CreateStyleRequestVariant2;

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleRequest(global::Recraft.CreateStyleRequestVariant2? value)
        {
            CreateStyleRequestVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateStyleRequest FromCreateStyleRequestVariant2(global::Recraft.CreateStyleRequestVariant2? value) => new CreateStyleRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateStyleRequest(
            global::Recraft.CreateStyleRequestBase? @base,
            global::Recraft.CreateStyleRequestVariant2? createStyleRequestVariant2
            )
        {
            Base = @base;
            CreateStyleRequestVariant2 = createStyleRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            CreateStyleRequestVariant2 as object ??
            Base as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Base?.ToString() ??
            CreateStyleRequestVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBase && IsCreateStyleRequestVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.CreateStyleRequestBase, TResult>? @base = null,
            global::System.Func<global::Recraft.CreateStyleRequestVariant2, TResult>? createStyleRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase && @base != null)
            {
                return @base(Base!);
            }
            else if (IsCreateStyleRequestVariant2 && createStyleRequestVariant2 != null)
            {
                return createStyleRequestVariant2(CreateStyleRequestVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.CreateStyleRequestBase>? @base = null,

            global::System.Action<global::Recraft.CreateStyleRequestVariant2>? createStyleRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCreateStyleRequestVariant2)
            {
                createStyleRequestVariant2?.Invoke(CreateStyleRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.CreateStyleRequestBase>? @base = null,
            global::System.Action<global::Recraft.CreateStyleRequestVariant2>? createStyleRequestVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBase)
            {
                @base?.Invoke(Base!);
            }
            else if (IsCreateStyleRequestVariant2)
            {
                createStyleRequestVariant2?.Invoke(CreateStyleRequestVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base,
                typeof(global::Recraft.CreateStyleRequestBase),
                CreateStyleRequestVariant2,
                typeof(global::Recraft.CreateStyleRequestVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(CreateStyleRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.CreateStyleRequestBase?>.Default.Equals(Base, other.Base) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.CreateStyleRequestVariant2?>.Default.Equals(CreateStyleRequestVariant2, other.CreateStyleRequestVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateStyleRequest obj1, CreateStyleRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateStyleRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateStyleRequest obj1, CreateStyleRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateStyleRequest o && Equals(o);
        }
    }
}

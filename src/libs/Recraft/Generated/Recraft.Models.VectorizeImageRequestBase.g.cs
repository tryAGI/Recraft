#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Recraft
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct VectorizeImageRequestBase : global::System.IEquatable<VectorizeImageRequestBase>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.ProcessImageRequestBase? Process { get; init; }
#else
        public global::Recraft.ProcessImageRequestBase? Process { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Process))]
#endif
        public bool IsProcess => Process != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProcess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.ProcessImageRequestBase? value)
        {
            value = Process;
            return IsProcess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.ProcessImageRequestBase PickProcess() => IsProcess
            ? Process!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Process' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Recraft.VectorizeImageRequestBaseVariant2? VectorizeImageRequestBaseVariant2 { get; init; }
#else
        public global::Recraft.VectorizeImageRequestBaseVariant2? VectorizeImageRequestBaseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VectorizeImageRequestBaseVariant2))]
#endif
        public bool IsVectorizeImageRequestBaseVariant2 => VectorizeImageRequestBaseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVectorizeImageRequestBaseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Recraft.VectorizeImageRequestBaseVariant2? value)
        {
            value = VectorizeImageRequestBaseVariant2;
            return IsVectorizeImageRequestBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Recraft.VectorizeImageRequestBaseVariant2 PickVectorizeImageRequestBaseVariant2() => IsVectorizeImageRequestBaseVariant2
            ? VectorizeImageRequestBaseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VectorizeImageRequestBaseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageRequestBase(global::Recraft.ProcessImageRequestBase value) => new VectorizeImageRequestBase((global::Recraft.ProcessImageRequestBase?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.ProcessImageRequestBase?(VectorizeImageRequestBase @this) => @this.Process;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequestBase(global::Recraft.ProcessImageRequestBase? value)
        {
            Process = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorizeImageRequestBase FromProcess(global::Recraft.ProcessImageRequestBase? value) => new VectorizeImageRequestBase(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator VectorizeImageRequestBase(global::Recraft.VectorizeImageRequestBaseVariant2 value) => new VectorizeImageRequestBase((global::Recraft.VectorizeImageRequestBaseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Recraft.VectorizeImageRequestBaseVariant2?(VectorizeImageRequestBase @this) => @this.VectorizeImageRequestBaseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequestBase(global::Recraft.VectorizeImageRequestBaseVariant2? value)
        {
            VectorizeImageRequestBaseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static VectorizeImageRequestBase FromVectorizeImageRequestBaseVariant2(global::Recraft.VectorizeImageRequestBaseVariant2? value) => new VectorizeImageRequestBase(value);

        /// <summary>
        /// 
        /// </summary>
        public VectorizeImageRequestBase(
            global::Recraft.ProcessImageRequestBase? process,
            global::Recraft.VectorizeImageRequestBaseVariant2? vectorizeImageRequestBaseVariant2
            )
        {
            Process = process;
            VectorizeImageRequestBaseVariant2 = vectorizeImageRequestBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VectorizeImageRequestBaseVariant2 as object ??
            Process as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Process?.ToString() ??
            VectorizeImageRequestBaseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsProcess && IsVectorizeImageRequestBaseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Recraft.ProcessImageRequestBase, TResult>? process = null,
            global::System.Func<global::Recraft.VectorizeImageRequestBaseVariant2, TResult>? vectorizeImageRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcess && process != null)
            {
                return process(Process!);
            }
            else if (IsVectorizeImageRequestBaseVariant2 && vectorizeImageRequestBaseVariant2 != null)
            {
                return vectorizeImageRequestBaseVariant2(VectorizeImageRequestBaseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Recraft.ProcessImageRequestBase>? process = null,

            global::System.Action<global::Recraft.VectorizeImageRequestBaseVariant2>? vectorizeImageRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcess)
            {
                process?.Invoke(Process!);
            }
            else if (IsVectorizeImageRequestBaseVariant2)
            {
                vectorizeImageRequestBaseVariant2?.Invoke(VectorizeImageRequestBaseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Recraft.ProcessImageRequestBase>? process = null,
            global::System.Action<global::Recraft.VectorizeImageRequestBaseVariant2>? vectorizeImageRequestBaseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsProcess)
            {
                process?.Invoke(Process!);
            }
            else if (IsVectorizeImageRequestBaseVariant2)
            {
                vectorizeImageRequestBaseVariant2?.Invoke(VectorizeImageRequestBaseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Process,
                typeof(global::Recraft.ProcessImageRequestBase),
                VectorizeImageRequestBaseVariant2,
                typeof(global::Recraft.VectorizeImageRequestBaseVariant2),
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
        public bool Equals(VectorizeImageRequestBase other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Recraft.ProcessImageRequestBase?>.Default.Equals(Process, other.Process) &&
                global::System.Collections.Generic.EqualityComparer<global::Recraft.VectorizeImageRequestBaseVariant2?>.Default.Equals(VectorizeImageRequestBaseVariant2, other.VectorizeImageRequestBaseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(VectorizeImageRequestBase obj1, VectorizeImageRequestBase obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VectorizeImageRequestBase>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(VectorizeImageRequestBase obj1, VectorizeImageRequestBase obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VectorizeImageRequestBase o && Equals(o);
        }
    }
}
